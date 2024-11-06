using Microsoft.Maui.Controls;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace SmartOrganizer
{
    public partial class CalendarPage : ContentPage
    {
        public CalendarPage()
        {
            InitializeComponent();
            InitializeMonthAndYearPickers();
            LoadCalendar(DateTime.Now.Month, DateTime.Now.Year);
        }

        private void InitializeMonthAndYearPickers()
        {
            MonthPicker.ItemsSource = CultureInfo.CurrentCulture.DateTimeFormat.MonthNames[..^1];
            MonthPicker.SelectedIndexChanged += (s, e) =>
            {
                if (YearPicker.SelectedIndex >= 0)
                {
                    int selectedMonth = MonthPicker.SelectedIndex + 1;
                    int selectedYear;
                    if (int.TryParse(YearPicker.SelectedItem?.ToString(), out selectedYear))
                    {
                        LoadCalendar(selectedMonth, selectedYear);
                    }
                }
            };

            var currentYear = DateTime.Now.Year;
            List<int> years = new List<int>();
            for (int i = currentYear - 5; i <= currentYear + 5; i++)
            {
                years.Add(i);
            }
            YearPicker.ItemsSource = years;
            YearPicker.SelectedIndexChanged += (s, e) =>
            {
                if (MonthPicker.SelectedIndex >= 0)
                {
                    int selectedMonth = MonthPicker.SelectedIndex + 1;
                    int selectedYear;
                    if (int.TryParse(YearPicker.SelectedItem?.ToString(), out selectedYear))
                    {
                        LoadCalendar(selectedMonth, selectedYear);
                    }
                }
            };

            MonthPicker.SelectedIndex = DateTime.Now.Month - 1;
            YearPicker.SelectedIndex = 5;
        }

        private void LoadCalendar(int month, int year)
        {
            CalendarGrid.Children.Clear();

            string[] daysOfWeek = { "Pn", "Wt", "Œr", "Cz", "Pt", "Sb", "Nd" };
            for (int i = 0; i < daysOfWeek.Length; i++)
            {
                Label dayLabel = new Label
                {
                    Text = daysOfWeek[i],
                    HorizontalOptions = LayoutOptions.Center,
                    TextColor = Colors.Red
                };
                CalendarGrid.Children.Add(dayLabel);
                Grid.SetRow(dayLabel, 0);
                Grid.SetColumn(dayLabel, i);
            }

            int daysInMonth = DateTime.DaysInMonth(year, month);
            DateTime firstDayOfMonth = new DateTime(year, month, 1);
            int startDay = (int)firstDayOfMonth.DayOfWeek - 1;
            if (startDay < 0) startDay = 6;

            int dayCounter = 1;
            for (int row = 1; row < 7; row++)
            {
                for (int column = 0; column < 7; column++)
                {
                    if (row == 1 && column < startDay)
                    {
                        continue;
                    }
                    if (dayCounter > daysInMonth)
                    {
                        break;
                    }

                    Label dayLabel = new Label
                    {
                        Text = dayCounter.ToString(),
                        HorizontalOptions = LayoutOptions.Center,
                        VerticalOptions = LayoutOptions.Center,
                        TextColor = Colors.Black
                    };
                    CalendarGrid.Children.Add(dayLabel);
                    Grid.SetRow(dayLabel, row);
                    Grid.SetColumn(dayLabel, column);
                    dayCounter++;
                }
            }
        }
    }
}