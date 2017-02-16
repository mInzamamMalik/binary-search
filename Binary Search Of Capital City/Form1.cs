using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Binary_Search_Of_Capital_City
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string item, Capital;
        int location, index, sizeOfArray, first, last ;
        string[] countries = new string[] { "afghanistan", "albania", "algeria", "bahrain", "bangladesh", "brazil", "canada", "china", "denmark", "egypt", "india", "pakistan", "qatar" };
        string[] cities = new string[] { "Kabul", "Tirana", "Algiers", "	Manama", "Dhaka", "Brasilia", "Ottawa", "Beijing", "Copenhagen", "Cairo", "New Delhi", "Islamabad", "Doha" };

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            sizeOfArray = countries.Length;
            first = 0;
            last = sizeOfArray - 1;
            item = textBox1.Text.ToLower();


            index = BinarySearch(countries, sizeOfArray, item);
            {
                if (index == -1)
                {
                    MessageBox.Show("Not  Found");
                }
                else if (index == -2)
                {
                    MessageBox.Show("Array is empty");
                }
                else
                {
                    int sizeOfCities = cities.Length;
                    Capital = cities[index];
                    label1.Text = Capital;

                   
                }

            }
        }

        private int BinarySearch(string[] countries, int sizeOfArray, string item)
        {
            int FST=0, LST=sizeOfArray-1, mid;

            while (FST <= LST)
            {
                mid = FST + (LST-FST) / 2; //10
                if (sizeOfArray == 0)
                {
                    location = -2;
                    break;
                }

                if (item == countries[mid])
                {
                    location = mid;
                    break;
                }
                 //else if (item < countries[mid])
                else if (string.Compare(item, countries[mid], true) < 0)
                {
                    LST = mid - 1;
                    //return BinarySearch(countries, FST, mid - 1, item);
                    //mid = first + last / 2;

                   
                   
                }
                else if (string.Compare(item, countries[mid], true) > 0)
                {
                    FST = mid + 1;
                    //return BinarySearch(countries, mid+1, LST, item);
                    
                    

                   // break;
                }
                else
                {
                    location = -1;
                    break;
                }
            }

            return location;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
            
        }

        private void CheckCountry()
        {
           
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            
        }

        private void textBox1_MouseLeave(object sender, EventArgs e)
        {
          
        }
    }
}