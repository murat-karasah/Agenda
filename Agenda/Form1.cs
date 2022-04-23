using System.Collections.Generic;
using System.Globalization;

namespace Agenda
{
    public partial class Form1 : Form
    {
        Object[] ItemWeekObject = new Object[8];
        Object[] ItemDayObject = new Object[31];
        List<DateTime> DaysList= new List<DateTime>();
        List<string> StringDaysList = new List<string>();
        int Days;

        DateTime firstDate= DateTime.MinValue, secondDate= DateTime.MinValue;

        public Form1()
        {
            InitializeComponent();
            StartHide();
            ComboBoxSelected();
            DayWeekCreated();
           
        }

        private void DayWeekCreated()
        {
            for (int i = 0; i < ItemWeekObject.Count(); i++)
            {
                ItemWeekObject[i] = (i + 1) + "Haftalýk";
            }
            for (int i = 0; i < ItemDayObject.Count(); i++)
            {
                ItemDayObject[i] = (i + 1) + "Günlük";
            }
        }

        private void StartHide()
        {
            comboBox2.Visible = false;
            groupBox1.Visible = false;
        }

        private void ComboBoxSelected()
        {
            comboBox1.Items.Add("Günlük");
            comboBox1.Items.Add("Haftalýk");

        }

       

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedItem)
            {
                case "Günlük":
                    comboBox2.Items.Clear();
                    comboBox2.Items.AddRange(ItemDayObject);
                    StartHide();
                    comboBox2.Visible = true;
                    break;
                case "Haftalýk":
                    comboBox2.Items.Clear();
                    comboBox2.Items.AddRange(ItemWeekObject);
                    StartHide();
                    comboBox2.Visible = true;
                    groupBox1.Visible=true;
                    break;
            }
        }

        private void monthCalendar2_DateSelected(object sender, DateRangeEventArgs e)
        {
             firstDate = monthCalendar2.SelectionStart;

            DayRangeList();

        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
             secondDate = monthCalendar1.SelectionStart;
            

            DayRangeList();

        }

        private void DayRangeList()
        {
            listBox1.Items.Clear();
             if (firstDate!= DateTime.MinValue && secondDate!= DateTime.MinValue)
            {

                DayExtraction();
                DaysList.Add(firstDate);
                int index = comboBox2.SelectedIndex;
                if (index==-1)
                {
                    
                }
                else
                {
                    for (int i = 0; i < Days; i++)
                    {
                        firstDate = firstDate.AddDays(index + 1);
                        if (firstDate > secondDate)
                        {
                            break;
                        }
                        else
                        {
                            DaysList.Add(firstDate);

                        }
                    }

                    foreach (var item in DaysList)
                    {
                        StringDaysList.Add(item.ToString("d"));
                    }
                    foreach (var emp in StringDaysList)
                        listBox1.Items.Add(emp);
                }
                DaysList.Clear();
                StringDaysList.Clear();
                firstDate = DateTime.MinValue;
                secondDate=DateTime.MinValue;
            }
          
        }

       

        private void DayExtraction()
        {
            TimeSpan days = secondDate - firstDate;
            Days= days.Days;
        }
    }
}