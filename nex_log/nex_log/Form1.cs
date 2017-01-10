using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace nex_log
{
    public partial class Form1 : Form
    {
        String[] itemIDs = {"1753", "20151", "20155", "20147", "25664", "20159", "20167", "20163", "9245", "25068", "25058", "25064", "20135", "25060", "20139", "20143",
                            "25066", "25062", "1631", "211", "217", "219", "1513", "453", "451", "6685", "3024", "5316", "5304", "25654", "20171"};

        List<RootObject> grabbedItems = new List<RootObject>();

        String filepath = null;

        System.IO.StreamWriter logFile = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void button33_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            for (int i = 0; i < itemIDs.Length; ++i)
            {
                //create web object
                WebRequest apiRequest = WebRequest.Create("http://services.runescape.com/m=itemdb_rs/api/catalogue/detail.json?item=" + itemIDs[i]);

                //get ge api response
                WebResponse apiResponse = apiRequest.GetResponse();

                //get stream
                Stream apiStream = apiResponse.GetResponseStream();

                //create reader
                StreamReader apiReader = new StreamReader(apiStream);

                //read from reader
                string responseFromServer = apiReader.ReadToEnd();

                try
                {
                    grabbedItems.Add(JsonConvert.DeserializeObject<RootObject>(responseFromServer));
                }
                catch
                {

                }
            }
            this.Cursor = Cursors.Default;
            MessageBox.Show("Finished fetching prices");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                String priceString = grabbedItems.ElementAt(3).item.current.price;
                int price = 0;
                if (priceString.Substring(priceString.Length - 1, 1).Equals("m"))
                {
                    price = Convert.ToInt32(Convert.ToDouble(priceString.Substring(0, priceString.Length - 1)) * 1000000);
                }
                else if (priceString.Substring(priceString.Length - 1, 1).Equals("k"))
                {
                    price = Convert.ToInt32(Convert.ToDouble(priceString.Substring(0, priceString.Length - 1)) * 1000);
                }
                else
                {
                    if (priceString.Contains(","))
                    {
                        priceString = priceString.Remove(priceString.IndexOf(','), 1);
                    }
                    price = Convert.ToInt32(priceString);
                }
                logFile.WriteLine(grabbedItems.ElementAt(3).item.name + "," + price);
                MessageBox.Show(grabbedItems.ElementAt(3).item.name + " was added to the log!");
            }
            catch (Exception err)
            {
                MessageBox.Show("Error encountered: Open a file and load prices.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                String priceString = grabbedItems.ElementAt(1).item.current.price;
                int price = 0;
                if (priceString.Substring(priceString.Length - 1, 1).Equals("m"))
                {
                    price = Convert.ToInt32(Convert.ToDouble(priceString.Substring(0, priceString.Length - 1)) * 1000000);
                }
                else if (priceString.Substring(priceString.Length - 1, 1).Equals("k"))
                {
                    price = Convert.ToInt32(Convert.ToDouble(priceString.Substring(0, priceString.Length - 1)) * 1000);
                }
                else
                {
                    if (priceString.Contains(","))
                    {
                        priceString = priceString.Remove(priceString.IndexOf(','), 1);
                    }
                    price = Convert.ToInt32(priceString);
                }
                logFile.WriteLine(grabbedItems.ElementAt(1).item.name + "," + price);
                MessageBox.Show(grabbedItems.ElementAt(1).item.name + " was added to the log!");
            }
            catch (Exception err)
            {
                MessageBox.Show("Error encountered: Open a file and load prices.");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                String priceString = grabbedItems.ElementAt(2).item.current.price;
                int price = 0;
                if (priceString.Substring(priceString.Length - 1, 1).Equals("m"))
                {
                    price = Convert.ToInt32(Convert.ToDouble(priceString.Substring(0, priceString.Length - 1)) * 1000000);
                }
                else if (priceString.Substring(priceString.Length - 1, 1).Equals("k"))
                {
                    price = Convert.ToInt32(Convert.ToDouble(priceString.Substring(0, priceString.Length - 1)) * 1000);
                }
                else
                {
                    if (priceString.Contains(","))
                    {
                        priceString = priceString.Remove(priceString.IndexOf(','), 1);
                    }
                    price = Convert.ToInt32(priceString);
                }
                logFile.WriteLine(grabbedItems.ElementAt(2).item.name + "," + price);
                MessageBox.Show(grabbedItems.ElementAt(2).item.name + " was added to the log!");
            }
            catch (Exception err)
            {
                MessageBox.Show("Error encountered: Open a file and load prices.");
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            try
            {
                String priceString = grabbedItems.ElementAt(10).item.current.price;
                int price = 0;
                if (priceString.Substring(priceString.Length - 1, 1).Equals("m"))
                {
                    price = Convert.ToInt32(Convert.ToDouble(priceString.Substring(0, priceString.Length - 1)) * 1000000);
                }
                else if (priceString.Substring(priceString.Length - 1, 1).Equals("k"))
                {
                    price = Convert.ToInt32(Convert.ToDouble(priceString.Substring(0, priceString.Length - 1)) * 1000);
                }
                else
                {
                    if (priceString.Contains(","))
                    {
                        priceString = priceString.Remove(priceString.IndexOf(','), 1);
                    }
                    price = Convert.ToInt32(priceString);
                }
                logFile.WriteLine(grabbedItems.ElementAt(10).item.name + "," + price);
                MessageBox.Show(grabbedItems.ElementAt(10).item.name + " was added to the log!");
            }
            catch (Exception err)
            {
                MessageBox.Show("Error encountered: Open a file and load prices.");
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            try
            {
                String priceString = grabbedItems.ElementAt(9).item.current.price;
                int price = 0;
                if (priceString.Substring(priceString.Length - 1, 1).Equals("m"))
                {
                    price = Convert.ToInt32(Convert.ToDouble(priceString.Substring(0, priceString.Length - 1)) * 1000000);
                }
                else if (priceString.Substring(priceString.Length - 1, 1).Equals("k"))
                {
                    price = Convert.ToInt32(Convert.ToDouble(priceString.Substring(0, priceString.Length - 1)) * 1000);
                }
                else
                {
                    if (priceString.Contains(","))
                    {
                        priceString = priceString.Remove(priceString.IndexOf(','), 1);
                    }
                    price = Convert.ToInt32(priceString);
                }
                logFile.WriteLine(grabbedItems.ElementAt(9).item.name + "," + price);
                MessageBox.Show(grabbedItems.ElementAt(9).item.name + " was added to the log!");
            }
            catch (Exception err)
            {
                MessageBox.Show("Error encountered: Open a file and load prices.");
            }
        }

        private void button31_Click(object sender, EventArgs e)
        {
            try
            {
                String priceString = grabbedItems.ElementAt(30).item.current.price;
                int price = 0;
                if (priceString.Substring(priceString.Length - 1, 1).Equals("m"))
                {
                    price = Convert.ToInt32(Convert.ToDouble(priceString.Substring(0, priceString.Length - 1)) * 1000000);
                }
                else if (priceString.Substring(priceString.Length - 1, 1).Equals("k"))
                {
                    price = Convert.ToInt32(Convert.ToDouble(priceString.Substring(0, priceString.Length - 1)) * 1000);
                }
                else
                {
                    if (priceString.Contains(","))
                    {
                        priceString = priceString.Remove(priceString.IndexOf(','), 1);
                    }
                    price = Convert.ToInt32(priceString);
                }
                logFile.WriteLine(grabbedItems.ElementAt(30).item.name + "," + price);
                MessageBox.Show(grabbedItems.ElementAt(30).item.name + " was added to the log!");
            }
            catch (Exception err)
            {
                MessageBox.Show("Error encountered: Open a file and load prices.");
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            try
            {
                String priceString = grabbedItems.ElementAt(12).item.current.price;
                int price = 0;
                if (priceString.Substring(priceString.Length - 1, 1).Equals("m"))
                {
                    price = Convert.ToInt32(Convert.ToDouble(priceString.Substring(0, priceString.Length - 1)) * 1000000);
                }
                else if (priceString.Substring(priceString.Length - 1, 1).Equals("k"))
                {
                    price = Convert.ToInt32(Convert.ToDouble(priceString.Substring(0, priceString.Length - 1)) * 1000);
                }
                else
                {
                    if (priceString.Contains(","))
                    {
                        priceString = priceString.Remove(priceString.IndexOf(','), 1);
                    }
                    price = Convert.ToInt32(priceString);
                }
                logFile.WriteLine(grabbedItems.ElementAt(12).item.name + "," + price);
                MessageBox.Show(grabbedItems.ElementAt(12).item.name + " was added to the log!");
            }
            catch (Exception err)
            {
                MessageBox.Show("Error encountered: Open a file and load prices.");
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            try
            {
                String priceString = grabbedItems.ElementAt(14).item.current.price;
                int price = 0;
                if (priceString.Substring(priceString.Length - 1, 1).Equals("m"))
                {
                    price = Convert.ToInt32(Convert.ToDouble(priceString.Substring(0, priceString.Length - 1)) * 1000000);
                }
                else if (priceString.Substring(priceString.Length - 1, 1).Equals("k"))
                {
                    price = Convert.ToInt32(Convert.ToDouble(priceString.Substring(0, priceString.Length - 1)) * 1000);
                }
                else
                {
                    if (priceString.Contains(","))
                    {
                        priceString = priceString.Remove(priceString.IndexOf(','), 1);
                    }
                    price = Convert.ToInt32(priceString);
                }
                logFile.WriteLine(grabbedItems.ElementAt(14).item.name + "," + price);
                MessageBox.Show(grabbedItems.ElementAt(14).item.name + " was added to the log!");
            }
            catch (Exception err)
            {
                MessageBox.Show("Error encountered: Open a file and load prices.");
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            try
            {
                String priceString = grabbedItems.ElementAt(15).item.current.price;
                int price = 0;
                if (priceString.Substring(priceString.Length - 1, 1).Equals("m"))
                {
                    price = Convert.ToInt32(Convert.ToDouble(priceString.Substring(0, priceString.Length - 1)) * 1000000);
                }
                else if (priceString.Substring(priceString.Length - 1, 1).Equals("k"))
                {
                    price = Convert.ToInt32(Convert.ToDouble(priceString.Substring(0, priceString.Length - 1)) * 1000);
                }
                else
                {
                    if (priceString.Contains(","))
                    {
                        priceString = priceString.Remove(priceString.IndexOf(','), 1);
                    }
                    price = Convert.ToInt32(priceString);
                }
                logFile.WriteLine(grabbedItems.ElementAt(15).item.name + "," + price);
                MessageBox.Show(grabbedItems.ElementAt(15).item.name + " was added to the log!");
            }
            catch (Exception err)
            {
                MessageBox.Show("Error encountered: Open a file and load prices.");
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            try
            {
                String priceString = grabbedItems.ElementAt(11).item.current.price;
                int price = 0;
                if (priceString.Substring(priceString.Length - 1, 1).Equals("m"))
                {
                    price = Convert.ToInt32(Convert.ToDouble(priceString.Substring(0, priceString.Length - 1)) * 1000000);
                }
                else if (priceString.Substring(priceString.Length - 1, 1).Equals("k"))
                {
                    price = Convert.ToInt32(Convert.ToDouble(priceString.Substring(0, priceString.Length - 1)) * 1000);
                }
                else
                {
                    if (priceString.Contains(","))
                    {
                        priceString = priceString.Remove(priceString.IndexOf(','), 1);
                    }
                    price = Convert.ToInt32(priceString);
                }
                logFile.WriteLine(grabbedItems.ElementAt(11).item.name + "," + price);
                MessageBox.Show(grabbedItems.ElementAt(11).item.name + " was added to the log!");
            }
            catch (Exception err)
            {
                MessageBox.Show("Error encountered: Open a file and load prices.");
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            try
            {
                String priceString = grabbedItems.ElementAt(13).item.current.price;
                int price = 0;
                if (priceString.Substring(priceString.Length - 1, 1).Equals("m"))
                {
                    price = Convert.ToInt32(Convert.ToDouble(priceString.Substring(0, priceString.Length - 1)) * 1000000);
                }
                else if (priceString.Substring(priceString.Length - 1, 1).Equals("k"))
                {
                    price = Convert.ToInt32(Convert.ToDouble(priceString.Substring(0, priceString.Length - 1)) * 1000);
                }
                else
                {
                    if (priceString.Contains(","))
                    {
                        priceString = priceString.Remove(priceString.IndexOf(','), 1);
                    }
                    price = Convert.ToInt32(priceString);
                }
                logFile.WriteLine(grabbedItems.ElementAt(13).item.name + "," + price);
                MessageBox.Show(grabbedItems.ElementAt(13).item.name + " was added to the log!");
            }
            catch (Exception err)
            {
                MessageBox.Show("Error encountered: Open a file and load prices.");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                String priceString = grabbedItems.ElementAt(5).item.current.price;
                int price = 0;
                if (priceString.Substring(priceString.Length - 1, 1).Equals("m"))
                {
                    price = Convert.ToInt32(Convert.ToDouble(priceString.Substring(0, priceString.Length - 1)) * 1000000);
                }
                else if (priceString.Substring(priceString.Length - 1, 1).Equals("k"))
                {
                    price = Convert.ToInt32(Convert.ToDouble(priceString.Substring(0, priceString.Length - 1)) * 1000);
                }
                else
                {
                    if (priceString.Contains(","))
                    {
                        priceString = priceString.Remove(priceString.IndexOf(','), 1);
                    }
                    price = Convert.ToInt32(priceString);
                }
                logFile.WriteLine(grabbedItems.ElementAt(5).item.name + "," + price);
                MessageBox.Show(grabbedItems.ElementAt(5).item.name + " was added to the log!");
            }
            catch (Exception err)
            {
                MessageBox.Show("Error encountered: Open a file and load prices.");
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                String priceString = grabbedItems.ElementAt(7).item.current.price;
                int price = 0;
                if (priceString.Substring(priceString.Length - 1, 1).Equals("m"))
                {
                    price = Convert.ToInt32(Convert.ToDouble(priceString.Substring(0, priceString.Length - 1)) * 1000000);
                }
                else if (priceString.Substring(priceString.Length - 1, 1).Equals("k"))
                {
                    price = Convert.ToInt32(Convert.ToDouble(priceString.Substring(0, priceString.Length - 1)) * 1000);
                }
                else
                {
                    if (priceString.Contains(","))
                    {
                        priceString = priceString.Remove(priceString.IndexOf(','), 1);
                    }
                    price = Convert.ToInt32(priceString);
                }
                logFile.WriteLine(grabbedItems.ElementAt(7).item.name + "," + price);
                MessageBox.Show(grabbedItems.ElementAt(7).item.name + " was added to the log!");
            }
            catch (Exception err)
            {
                MessageBox.Show("Error encountered: Open a file and load prices.");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                String priceString = grabbedItems.ElementAt(6).item.current.price;
                int price = 0;
                if (priceString.Substring(priceString.Length - 1, 1).Equals("m"))
                {
                    price = Convert.ToInt32(Convert.ToDouble(priceString.Substring(0, priceString.Length - 1)) * 1000000);
                }
                else if (priceString.Substring(priceString.Length - 1, 1).Equals("k"))
                {
                    price = Convert.ToInt32(Convert.ToDouble(priceString.Substring(0, priceString.Length - 1)) * 1000);
                }
                else
                {
                    if (priceString.Contains(","))
                    {
                        priceString = priceString.Remove(priceString.IndexOf(','), 1);
                    }
                    price = Convert.ToInt32(priceString);
                }
                logFile.WriteLine(grabbedItems.ElementAt(6).item.name + "," + price);
                MessageBox.Show(grabbedItems.ElementAt(6).item.name + " was added to the log!");
            }
            catch (Exception err)
            {
                MessageBox.Show("Error encountered: Open a file and load prices.");
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            try
            {
                String priceString = grabbedItems.ElementAt(17).item.current.price;
                int price = 0;
                if (priceString.Substring(priceString.Length - 1, 1).Equals("m"))
                {
                    price = Convert.ToInt32(Convert.ToDouble(priceString.Substring(0, priceString.Length - 1)) * 1000000);
                }
                else if (priceString.Substring(priceString.Length - 1, 1).Equals("k"))
                {
                    price = Convert.ToInt32(Convert.ToDouble(priceString.Substring(0, priceString.Length - 1)) * 1000);
                }
                else
                {
                    if (priceString.Contains(","))
                    {
                        priceString = priceString.Remove(priceString.IndexOf(','), 1);
                    }
                    price = Convert.ToInt32(priceString);
                }
                logFile.WriteLine(grabbedItems.ElementAt(17).item.name + "," + price);
                MessageBox.Show(grabbedItems.ElementAt(17).item.name + " was added to the log!");
            }
            catch (Exception err)
            {
                MessageBox.Show("Error encountered: Open a file and load prices.");
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            try
            {
                String priceString = grabbedItems.ElementAt(16).item.current.price;
                int price = 0;
                if (priceString.Substring(priceString.Length - 1, 1).Equals("m"))
                {
                    price = Convert.ToInt32(Convert.ToDouble(priceString.Substring(0, priceString.Length - 1)) * 1000000);
                }
                else if (priceString.Substring(priceString.Length - 1, 1).Equals("k"))
                {
                    price = Convert.ToInt32(Convert.ToDouble(priceString.Substring(0, priceString.Length - 1)) * 1000);
                }
                else
                {
                    if (priceString.Contains(","))
                    {
                        priceString = priceString.Remove(priceString.IndexOf(','), 1);
                    }
                    price = Convert.ToInt32(priceString);
                }
                logFile.WriteLine(grabbedItems.ElementAt(16).item.name + "," + price);
                MessageBox.Show(grabbedItems.ElementAt(16).item.name + " was added to the log!");
            }
            catch (Exception err)
            {
                MessageBox.Show("Error encountered: Open a file and load prices.");
            }
        }

        private void button30_Click(object sender, EventArgs e)
        {
            try
            {
                String priceString = grabbedItems.ElementAt(29).item.current.price;
                int price = 0;
                if (priceString.Substring(priceString.Length - 1, 1).Equals("m"))
                {
                    price = Convert.ToInt32(Convert.ToDouble(priceString.Substring(0, priceString.Length - 1)) * 1000000);
                }
                else if (priceString.Substring(priceString.Length - 1, 1).Equals("k"))
                {
                    price = Convert.ToInt32(Convert.ToDouble(priceString.Substring(0, priceString.Length - 1)) * 1000);
                }
                else
                {
                    if (priceString.Contains(","))
                    {
                        priceString = priceString.Remove(priceString.IndexOf(','), 1);
                    }
                    price = Convert.ToInt32(priceString);
                }
                logFile.WriteLine(grabbedItems.ElementAt(29).item.name + "," + price);
                MessageBox.Show(grabbedItems.ElementAt(29).item.name + " was added to the log!");
            }
            catch (Exception err)
            {
                MessageBox.Show("Error encountered: Open a file and load prices.");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                String priceString = grabbedItems.ElementAt(4).item.current.price;
                int price = 0;
                if (priceString.Substring(priceString.Length - 1, 1).Equals("m"))
                {
                    price = Convert.ToInt32(Convert.ToDouble(priceString.Substring(0, priceString.Length - 1)) * 1000000);
                }
                else if (priceString.Substring(priceString.Length - 1, 1).Equals("k"))
                {
                    price = Convert.ToInt32(Convert.ToDouble(priceString.Substring(0, priceString.Length - 1)) * 1000);
                }
                else
                {
                    if (priceString.Contains(","))
                    {
                        priceString = priceString.Remove(priceString.IndexOf(','), 1);
                    }
                    price = Convert.ToInt32(priceString);
                }
                logFile.WriteLine(grabbedItems.ElementAt(4).item.name + "," + price);
                MessageBox.Show(grabbedItems.ElementAt(4).item.name + " was added to the log!");
            }
            catch (Exception err)
            {
                MessageBox.Show("Error encountered: Open a file and load prices.");
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            try
            {
                String priceString = grabbedItems.ElementAt(8).item.current.price;
                int price = 0;
                if (priceString.Substring(priceString.Length - 1, 1).Equals("m"))
                {
                    price = Convert.ToInt32(Convert.ToDouble(priceString.Substring(0, priceString.Length - 1)) * 1000000);
                }
                else if (priceString.Substring(priceString.Length - 1, 1).Equals("k"))
                {
                    price = Convert.ToInt32(Convert.ToDouble(priceString.Substring(0, priceString.Length - 1)) * 1000);
                }
                else
                {
                    if (priceString.Contains(","))
                    {
                        priceString = priceString.Remove(priceString.IndexOf(','), 1);
                    }
                    price = Convert.ToInt32(priceString);
                }
                logFile.WriteLine(grabbedItems.ElementAt(8).item.name + "," + price*375);
                MessageBox.Show(grabbedItems.ElementAt(8).item.name + " was added to the log!");
            }
            catch (Exception err)
            {
                MessageBox.Show("Error encountered: Open a file and load prices.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                String priceString = grabbedItems.ElementAt(0).item.current.price;
                int price = 0;
                if (priceString.Substring(priceString.Length - 1, 1).Equals("m"))
                {
                    price = Convert.ToInt32(Convert.ToDouble(priceString.Substring(0, priceString.Length - 1)) * 1000000);
                }
                else if (priceString.Substring(priceString.Length - 1, 1).Equals("k"))
                {
                    price = Convert.ToInt32(Convert.ToDouble(priceString.Substring(0, priceString.Length - 1)) * 1000);
                }
                else
                {
                    if (priceString.Contains(","))
                    {
                        priceString = priceString.Remove(priceString.IndexOf(','), 1);
                    }
                    price = Convert.ToInt32(priceString);
                }
                logFile.WriteLine(grabbedItems.ElementAt(0).item.name + "," + price*400);
                MessageBox.Show(grabbedItems.ElementAt(0).item.name + " was added to the log!");
            }
            catch (Exception err)
            {
                MessageBox.Show("Error encountered: Open a file and load prices.");
            }
        }

        private void button26_Click(object sender, EventArgs e)
        {
            try
            {
                String priceString = grabbedItems.ElementAt(25).item.current.price;
                int price = 0;
                if (priceString.Substring(priceString.Length - 1, 1).Equals("m"))
                {
                    price = Convert.ToInt32(Convert.ToDouble(priceString.Substring(0, priceString.Length - 1)) * 1000000);
                }
                else if (priceString.Substring(priceString.Length - 1, 1).Equals("k"))
                {
                    price = Convert.ToInt32(Convert.ToDouble(priceString.Substring(0, priceString.Length - 1)) * 1000);
                }
                else
                {
                    if (priceString.Contains(","))
                    {
                        priceString = priceString.Remove(priceString.IndexOf(','), 1);
                    }
                    price = Convert.ToInt32(priceString);
                }
                logFile.WriteLine(grabbedItems.ElementAt(25).item.name + "," + price*30);
                MessageBox.Show(grabbedItems.ElementAt(25).item.name + " was added to the log!");
            }
            catch (Exception err)
            {
                MessageBox.Show("Error encountered: Open a file and load prices.");
            }
        }

        private void button27_Click(object sender, EventArgs e)
        {
            try
            {
                String priceString = grabbedItems.ElementAt(26).item.current.price;
                int price = 0;
                if (priceString.Substring(priceString.Length - 1, 1).Equals("m"))
                {
                    price = Convert.ToInt32(Convert.ToDouble(priceString.Substring(0, priceString.Length - 1)) * 1000000);
                }
                else if (priceString.Substring(priceString.Length - 1, 1).Equals("k"))
                {
                    price = Convert.ToInt32(Convert.ToDouble(priceString.Substring(0, priceString.Length - 1)) * 1000);
                }
                else
                {
                    if (priceString.Contains(","))
                    {
                        priceString = priceString.Remove(priceString.IndexOf(','), 1);
                    }
                    price = Convert.ToInt32(priceString);
                }
                logFile.WriteLine(grabbedItems.ElementAt(26).item.name + "," + price*30);
                MessageBox.Show(grabbedItems.ElementAt(26).item.name + " was added to the log!");
            }
            catch (Exception err)
            {
                MessageBox.Show("Error encountered: Open a file and load prices.");
            }
        }

        private void button25_Click(object sender, EventArgs e)
        {
            try
            {
                String priceString = grabbedItems.ElementAt(24).item.current.price;
                int price = 0;
                if (priceString.Substring(priceString.Length - 1, 1).Equals("m"))
                {
                    price = Convert.ToInt32(Convert.ToDouble(priceString.Substring(0, priceString.Length - 1)) * 1000000);
                }
                else if (priceString.Substring(priceString.Length - 1, 1).Equals("k"))
                {
                    price = Convert.ToInt32(Convert.ToDouble(priceString.Substring(0, priceString.Length - 1)) * 1000);
                }
                else
                {
                    if (priceString.Contains(","))
                    {
                        priceString = priceString.Remove(priceString.IndexOf(','), 1);
                    }
                    price = Convert.ToInt32(priceString);
                }
                logFile.WriteLine(grabbedItems.ElementAt(24).item.name + "," + price*80);
                MessageBox.Show(grabbedItems.ElementAt(24).item.name + " was added to the log!");
            }
            catch (Exception err)
            {
                MessageBox.Show("Error encountered: Open a file and load prices.");
            }
        }

        private void button24_Click(object sender, EventArgs e)
        {
            try
            {
                String priceString = grabbedItems.ElementAt(23).item.current.price;
                int price = 0;
                if (priceString.Substring(priceString.Length - 1, 1).Equals("m"))
                {
                    price = Convert.ToInt32(Convert.ToDouble(priceString.Substring(0, priceString.Length - 1)) * 1000000);
                }
                else if (priceString.Substring(priceString.Length - 1, 1).Equals("k"))
                {
                    price = Convert.ToInt32(Convert.ToDouble(priceString.Substring(0, priceString.Length - 1)) * 1000);
                }
                else
                {
                    if (priceString.Contains(","))
                    {
                        priceString = priceString.Remove(priceString.IndexOf(','), 1);
                    }
                    price = Convert.ToInt32(priceString);
                }
                logFile.WriteLine(grabbedItems.ElementAt(23).item.name + "," + price*2400);
                MessageBox.Show(grabbedItems.ElementAt(23).item.name + " was added to the log!");
            }
            catch (Exception err)
            {
                MessageBox.Show("Error encountered: Open a file and load prices.");
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            try
            {
                String priceString = grabbedItems.ElementAt(18).item.current.price;
                int price = 0;
                if (priceString.Substring(priceString.Length - 1, 1).Equals("m"))
                {
                    price = Convert.ToInt32(Convert.ToDouble(priceString.Substring(0, priceString.Length - 1)) * 1000000);
                }
                else if (priceString.Substring(priceString.Length - 1, 1).Equals("k"))
                {
                    price = Convert.ToInt32(Convert.ToDouble(priceString.Substring(0, priceString.Length - 1)) * 1000);
                }
                else
                {
                    if (priceString.Contains(","))
                    {
                        priceString = priceString.Remove(priceString.IndexOf(','), 1);
                    }
                    price = Convert.ToInt32(priceString);
                }
                logFile.WriteLine(grabbedItems.ElementAt(18).item.name + "," + price*20);
                MessageBox.Show(grabbedItems.ElementAt(18).item.name + " was added to the log!");
            }
            catch (Exception err)
            {
                MessageBox.Show("Error encountered: Open a file and load prices.");
            }
        }

        private void button23_Click(object sender, EventArgs e)
        {
            try
            {
                String priceString = grabbedItems.ElementAt(22).item.current.price;
                int price = 0;
                if (priceString.Substring(priceString.Length - 1, 1).Equals("m"))
                {
                    price = Convert.ToInt32(Convert.ToDouble(priceString.Substring(0, priceString.Length - 1)) * 1000000);
                }
                else if (priceString.Substring(priceString.Length - 1, 1).Equals("k"))
                {
                    price = Convert.ToInt32(Convert.ToDouble(priceString.Substring(0, priceString.Length - 1)) * 1000);
                }
                else
                {
                    if (priceString.Contains(","))
                    {
                        priceString = priceString.Remove(priceString.IndexOf(','), 1);
                    }
                    price = Convert.ToInt32(priceString);
                }
                logFile.WriteLine(grabbedItems.ElementAt(22).item.name + "," + price*375);
                MessageBox.Show(grabbedItems.ElementAt(22).item.name + " was added to the log!");
            }
            catch (Exception err)
            {
                MessageBox.Show("Error encountered: Open a file and load prices.");
            }
        }

        private void button28_Click(object sender, EventArgs e)
        {
            try
            {
                String priceString = grabbedItems.ElementAt(27).item.current.price;
                int price = 0;
                if (priceString.Substring(priceString.Length - 1, 1).Equals("m"))
                {
                    price = Convert.ToInt32(Convert.ToDouble(priceString.Substring(0, priceString.Length - 1)) * 1000000);
                }
                else if (priceString.Substring(priceString.Length - 1, 1).Equals("k"))
                {
                    price = Convert.ToInt32(Convert.ToDouble(priceString.Substring(0, priceString.Length - 1)) * 1000);
                }
                else
                {
                    if (priceString.Contains(","))
                    {
                        priceString = priceString.Remove(priceString.IndexOf(','), 1);
                    }
                    price = Convert.ToInt32(priceString);
                }
                logFile.WriteLine(grabbedItems.ElementAt(27).item.name + "," + price*5);
                MessageBox.Show(grabbedItems.ElementAt(27).item.name + " was added to the log!");
            }
            catch (Exception err)
            {
                MessageBox.Show("Error encountered: Open a file and load prices.");
            }
        }

        private void button29_Click(object sender, EventArgs e)
        {
            try
            {
                String priceString = grabbedItems.ElementAt(28).item.current.price;
                int price = 0;
                if (priceString.Substring(priceString.Length - 1, 1).Equals("m"))
                {
                    price = Convert.ToInt32(Convert.ToDouble(priceString.Substring(0, priceString.Length - 1)) * 1000000);
                }
                else if (priceString.Substring(priceString.Length - 1, 1).Equals("k"))
                {
                    price = Convert.ToInt32(Convert.ToDouble(priceString.Substring(0, priceString.Length - 1)) * 1000);
                }
                else
                {
                    if (priceString.Contains(","))
                    {
                        priceString = priceString.Remove(priceString.IndexOf(','), 1);
                    }
                    price = Convert.ToInt32(priceString);
                }
                logFile.WriteLine(grabbedItems.ElementAt(28).item.name + "," + price*12);
                MessageBox.Show(grabbedItems.ElementAt(28).item.name + " was added to the log!");
            }
            catch (Exception err)
            {
                MessageBox.Show("Error encountered: Open a file and load prices.");
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            try
            {
                String priceString = grabbedItems.ElementAt(20).item.current.price;
                int price = 0;
                if (priceString.Substring(priceString.Length - 1, 1).Equals("m"))
                {
                    price = Convert.ToInt32(Convert.ToDouble(priceString.Substring(0, priceString.Length - 1)) * 1000000);
                }
                else if (priceString.Substring(priceString.Length - 1, 1).Equals("k"))
                {
                    price = Convert.ToInt32(Convert.ToDouble(priceString.Substring(0, priceString.Length - 1)) * 1000);
                }
                else
                {
                    if (priceString.Contains(","))
                    {
                        priceString = priceString.Remove(priceString.IndexOf(','), 1);
                    }
                    price = Convert.ToInt32(priceString);
                }
                logFile.WriteLine(grabbedItems.ElementAt(20).item.name + "," + price*75);
                MessageBox.Show(grabbedItems.ElementAt(20).item.name + " was added to the log!");
            }
            catch (Exception err)
            {
                MessageBox.Show("Error encountered: Open a file and load prices.");
            }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            try
            {
                String priceString = grabbedItems.ElementAt(21).item.current.price;
                int price = 0;
                if (priceString.Substring(priceString.Length - 1, 1).Equals("m"))
                {
                    price = Convert.ToInt32(Convert.ToDouble(priceString.Substring(0, priceString.Length - 1)) * 1000000);
                }
                else if (priceString.Substring(priceString.Length - 1, 1).Equals("k"))
                {
                    price = Convert.ToInt32(Convert.ToDouble(priceString.Substring(0, priceString.Length - 1)) * 1000);
                }
                else
                {
                    if (priceString.Contains(","))
                    {
                        priceString = priceString.Remove(priceString.IndexOf(','), 1);
                    }
                    price = Convert.ToInt32(priceString);
                }
                logFile.WriteLine(grabbedItems.ElementAt(21).item.name + "," + price*40);
                MessageBox.Show(grabbedItems.ElementAt(21).item.name + " was added to the log!");
            }
            catch (Exception err)
            {
                MessageBox.Show("Error encountered: Open a file and load prices.");
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            try
            {
                String priceString = grabbedItems.ElementAt(19).item.current.price;
                int price = 0;
                if (priceString.Substring(priceString.Length - 1, 1).Equals("m"))
                {
                    price = Convert.ToInt32(Convert.ToDouble(priceString.Substring(0, priceString.Length - 1)) * 1000000);
                }
                else if (priceString.Substring(priceString.Length - 1, 1).Equals("k"))
                {
                    price = Convert.ToInt32(Convert.ToDouble(priceString.Substring(0, priceString.Length - 1)) * 1000);
                }
                else
                {
                    if (priceString.Contains(","))
                    {
                        priceString = priceString.Remove(priceString.IndexOf(','), 1);
                    }
                    price = Convert.ToInt32(priceString);
                }
                logFile.WriteLine(grabbedItems.ElementAt(19).item.name + "," + price*75);
                MessageBox.Show(grabbedItems.ElementAt(19).item.name + " was added to the log!");
            }
            catch (Exception err)
            {
                MessageBox.Show("Error encountered: Open a file and load prices.");
            }
        }

        private void button32_Click(object sender, EventArgs e)
        {
            try
            {
                logFile.WriteLine("Crap," + 0);
                MessageBox.Show("Crap was added to the log!");
            }
            catch (Exception err)
            {
                MessageBox.Show("Error encountered: Open a file and load prices.");
            }
        }

        private void button34_Click(object sender, EventArgs e)
        {
            OpenFileDialog browseLog = new OpenFileDialog();

            browseLog.InitialDirectory = "c:\\";
            browseLog.Filter = "txt files (*.txt)|*.txt|csv files (*.csv)|*.csv|All files(*.*)|*.*";
            browseLog.RestoreDirectory = true;

            if(browseLog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if((filepath = browseLog.FileName) != null)
                    {
                        logFile = new System.IO.StreamWriter(filepath, true);
                        logFile.AutoFlush = true;
                        MessageBox.Show("File opened successfully!");
                    }
                }
                catch
                {
                    MessageBox.Show("Could not open file.");
                }
            }
        }
    }
}
