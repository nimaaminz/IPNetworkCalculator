using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetworkExtractor
{
    public partial class Form1 : Form
    {

        private bool VALID_INPUTS = false;

        private bool MASK_ACTIVE = false;
        private bool CIDR_ACTIVE = false;

        private bool PROGRAM_MASK_CHANGE_TEXT = false;
        private bool PROGRAM_CIDR_CHANGE_TEXT = false;

        private int CIDR_INPUT = 0;

        private uint INPUT_SUBNET_MASK = 0;
        private uint INPUT_IP = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }



        private void txt_input_ip_TextChanged(object sender, EventArgs e)
        {
            string pattern = @"\b(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\b";
            if (Regex.IsMatch(txt_input_ip.Text, pattern))
            {

                IPAddress ip = null;

                if (IPAddress.TryParse(txt_input_ip.Text, out ip))
                {
                    VALID_INPUTS = true;


                    string[] octeds = txt_input_ip.Text.Split('.');

                    uint ipv4 = (uint)
                    (
                        int.Parse(octeds[0]) * Math.Pow(256, 3) +
                        int.Parse(octeds[1]) * Math.Pow(256, 2) +
                        int.Parse(octeds[2]) * 256 +
                        int.Parse(octeds[3])
                    );


                    INPUT_IP = ipv4;

                    calculate();

                }
                else
                {
                    VALID_INPUTS = false;
                }
            }
            else
            {
                VALID_INPUTS = false;
            }
        }

        private void txt_input_mask_TextChanged(object sender, EventArgs e)
        {
            string pattern = @"\b(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\b";
            if (!PROGRAM_MASK_CHANGE_TEXT)
            {
                if (Regex.IsMatch(txt_input_mask.Text, pattern))
                {
                    MASK_ACTIVE = true;
                    CIDR_ACTIVE = false;

                    string[] octeds = txt_input_mask.Text.Split('.');

                    uint ipv4 = (uint)
                    (
                        uint.Parse(octeds[0]) * Math.Pow(256, 3) +
                        uint.Parse(octeds[1]) * Math.Pow(256, 2) +
                        uint.Parse(octeds[2]) * 256 +
                        uint.Parse(octeds[3])
                    );

                    CIDR_INPUT = 0;
                    INPUT_SUBNET_MASK = ipv4;
                    calculate();

                }
            }
            else
            {
                PROGRAM_MASK_CHANGE_TEXT = false;
            }
        }


        private void input_cidr_ValueChanged(object sender, EventArgs e)
        {
            if (!PROGRAM_CIDR_CHANGE_TEXT)
            {
                MASK_ACTIVE = false;
                CIDR_ACTIVE = true;

                CIDR_INPUT = int.Parse(input_cidr.Value.ToString());
                INPUT_SUBNET_MASK = 0;

                calculate();
            }
            else
            {
                PROGRAM_CIDR_CHANGE_TEXT = false;
            }
        }


        private void calculate()
        {
            uint network_address = 0;
            uint subnet_mask = 0;

            if (CIDR_ACTIVE)
            {
                //int floor_8bit = (int)Math.Floor(decimal.Parse((CIDR_INPUT / 8).ToString())) ; 
                int floor_8bit = (int)Math.Floor((decimal)(CIDR_INPUT / 8));
                int after_pt = (CIDR_INPUT - (floor_8bit * 8));

                for (int i = 0; i < floor_8bit; i++)
                {
                    uint oc = ((uint)255 << ((3 - i) * 8));
                    subnet_mask |= oc;
                }

                for (int i = 0; i < after_pt; i++)
                {
                    subnet_mask |= ((uint)1 << ((3 - floor_8bit) * 8) + (8 - after_pt) + i);
                }



            }

            if (MASK_ACTIVE)
            {
                subnet_mask = INPUT_SUBNET_MASK;

                CIDR_INPUT = 0;

                for (int i = 0; i < 32; i++)
                {
                    if ((subnet_mask & (1<<i)) == 0)
                    {
                        CIDR_INPUT++ ; 
                    }
                    else
                    {
                        break ; 
                    }
                }

                CIDR_INPUT = 32 - CIDR_INPUT ;

            }

            network_address = subnet_mask & (uint)INPUT_IP;

            uint first_ip = network_address + 1;

            uint broad_cast = 0;

            for (int j = 0; j < 32 - CIDR_INPUT; j++)
            {
                broad_cast |= (uint)1 << j;
            }

            broad_cast |= network_address ; 



            uint last_ip = broad_cast - 1;


            // print network address . .  . 
            byte[] ip_net = new byte[4];
            ip_net = BitConverter.GetBytes(network_address);

            byte[] f_ip = new byte[4];
            f_ip = BitConverter.GetBytes(first_ip);

            byte[] br_ip = new byte[4];
            br_ip = BitConverter.GetBytes(broad_cast);

            byte[] ls_ip = new byte[4];
            ls_ip = BitConverter.GetBytes(last_ip);

            byte[] sub = new byte[4];
            sub = BitConverter.GetBytes(subnet_mask);



            char class_range = ip_net[3] >= 0 && ip_net[3] <= 127 ?
                'A'
                :
                (
                    ip_net[3] >= 128 && ip_net[3] <= 191 ?
                    'B'
                    :
                    'C'
                );


            Task.Run(() =>
            {
                switch (class_range)
                {
                    case 'A':
                        this.BackgroundImage = NetworkExtractor.Properties.Resources.A;
                        break;
                    case 'B':
                        this.BackgroundImage = NetworkExtractor.Properties.Resources.B;
                        break;
                    case 'C':
                        this.BackgroundImage = NetworkExtractor.Properties.Resources.C;
                        break;
                }

            });


            lbl_network_ip.Text = ip_net[3] + "." + ip_net[2] + "." + ip_net[1] + "." + ip_net[0];
            lbl_first_ip.Text = f_ip[3] + "." + f_ip[2] + "." + f_ip[1] + "." + f_ip[0];
            lbl_boradcast.Text = br_ip[3] + "." + br_ip[2] + "." + br_ip[1] + "." + br_ip[0];
            lbl_last_ip.Text = ls_ip[3] + "." + ls_ip[2] + "." + ls_ip[1] + "." + ls_ip[0];

            if (MASK_ACTIVE)
            {
                PROGRAM_CIDR_CHANGE_TEXT = true ; 
                input_cidr.Value = Math.Min(input_cidr.Maximum , Math.Max(CIDR_INPUT , input_cidr.Minimum)); 
            }

            lbl_host_count.Text = (Math.Pow(2, 32 - CIDR_INPUT) - 2).ToString();
            if (CIDR_ACTIVE)
            {
                PROGRAM_MASK_CHANGE_TEXT = true;
                txt_input_mask.Text = sub[3] + "." + sub[2] + "." + sub[1] + "." + sub[0];
            }


        }

    }
}
