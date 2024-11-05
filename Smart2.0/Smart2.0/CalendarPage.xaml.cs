using Microsoft.Maui.Controls;
using System;
using System.Collections.Generic;
using System.Globalization;
using Smart2._0;

namespace Smart2._0
{
    public partial class CalendarPage : ContentPage
    {
        public CalendarPage()
        {
            InitializeMonthAndYearPickers();
            LoadCalendar(DateTime.Now.Month, DateTime.Now.Year);
        }

        private void InitializeMonthAndYearPickers()
        {
        }

        private void LoadCalendar(int month, int year)
        {
        }
    }
}