int day1 = 0, year1 = 0, day2 = 0, year2 = 0, n, totalDay = 0, month__1, month__2, Year_1, Year_2, Month1 = 0, Month2 = 0, Day_1 = 0, Day_2 = 0, ctrlDay = 0;
            string month1, month2, month_1, month_2, Day1, Day2, Year1, Year2;    // We define the variables we use in the project.

            do
            {
                Console.ForegroundColor = ConsoleColor.DarkGray;         // We determine the font color and start to get the first date information.
                Console.WriteLine("Please enter the first date: ");
                do
                {                                                     //  We check the entered year value. If a negative or invalid year is entered, an error message is given and the year is requested again.
                    Console.Write("Year: ");
                    Year1 = Console.ReadLine();
                    int.TryParse(Year1, out Year_1);
                    if (Year_1 < 2015)
                    {
                        if (Year_1 < 0)
                            Console.WriteLine("You entered a negative value. Please enter a positive number.");
                        else if (Year_1 < 2015 && Year_1 > 0)
                            Console.WriteLine("The year you enter must be greater than 2015.");
                        else
                            Console.WriteLine("You entered an invalid value. Please try again.");
                    }
                } while (Year_1 < 2015);

                do                             // Month check is done here. One of the 12 months in the Gregorian calendar must be entered for the program to work.
                {                             //  If something invalid is entered, an error message is given and the month is requested again.
                    Console.Write("Month: ");
                    month1 = Console.ReadLine();
                    month_1 = month1.ToUpper();

                    switch (month_1)                                    // The entered months are converted to numbers here.
                    {
                        case "JANUARY": month__1 = 1; break;
                        case "FEBRUARY": month__1 = 2; break;
                        case "MARCH": month__1 = 3; break;
                        case "APRIL": month__1 = 4; break;
                        case "APRİL": month__1 = 4; break;
                        case "MAY": month__1 = 5; break;
                        case "JUNE": month__1 = 6; break;
                        case "JULY": month__1 = 7; break;
                        case "AUGUST": month__1 = 8; break;
                        case "SEPTEMBER": month__1 = 9; break;
                        case "OCTOBER": month__1 = 10; break;
                        case "NOVEMBER": month__1 = 11; break;
                        case "DECEMBER": month__1 = 12; break;
                        default: month__1 = -1; break;
                    }
                    if (month__1 == -1)
                        Console.WriteLine("You entered an invalid value. Please try again. (You must enter one of the 12 months in the Gregorian calendar.)");
                } while (month__1 < 1 || month__1 > 12);

                if (month__1 == 1 || month__1 == 3 || month__1 == 5 || month__1 == 7 || month__1 == 8 || month__1 == 10 || month__1 == 12)
                {
                    do                 // Day control is made according to the entered month. If an invalid day value is entered, an error message is given and the day is requested again.
                    {
                        Console.Write("Day: ");
                        Day1 = Console.ReadLine();
                        int.TryParse(Day1, out day1);
                        if (day1 > 31 || day1 < 1)
                        {
                            if (day1 > 31)
                                Console.WriteLine("This month can't be more than 31 days. Please enter a number between 1 and 31.");
                            else if (day1 < 0)
                                Console.WriteLine("You entered a negative value. Please enter a number between 1 and 31.");
                            else
                                Console.WriteLine("You entered an invalid value. Please try again.");
                        }
                    } while (day1 > 31 || day1 < 1);
                }

                else if (month__1 == 4 || month__1 == 6 || month__1 == 9 || month__1 == 11)
                {
                    do
                    {
                        Console.Write("Day: ");
                        Day1 = Console.ReadLine();
                        int.TryParse(Day1, out day1);
                        if (day1 > 30 || day1 < 1)
                        {
                            if (day1 > 30)
                                Console.WriteLine("This month can't be more than 30 days. Please enter a number between 1 and 30.");
                            else if (day1 < 0)
                                Console.WriteLine("You entered a negative value. Please enter a number between 1 and 30.");
                            else
                                Console.WriteLine("You entered an invalid value.Please try again.");
                        }

                    } while (day1 > 30 || day1 < 1);
                }

                else if (month__1 == 2 && Year_1 % 4 == 0)               // An additional check is made for the leap year.
                {
                    do
                    {
                        Console.Write("Day: ");
                        Day1 = Console.ReadLine();
                        int.TryParse(Day1, out day1);
                        if (day1 > 29 || day1 < 1)
                        {
                            if (day1 > 29)
                                Console.WriteLine("This month can't be more than 29 days. Please enter a number between 1 and 29.");
                            else if (day1 < 0)
                                Console.WriteLine("You entered a negative value. Please enter a number between 1 and 29.");
                            else
                                Console.WriteLine("You entered an invalid value.Please try again.");
                        }

                    } while (day1 > 29 || day1 < 1);

                }

                else if (month__1 == 2 && Year_1 % 4 != 0)
                {
                    do
                    {
                        Console.Write("Day: ");
                        Day1 = Console.ReadLine();
                        int.TryParse(Day1, out day1);
                        if (day1 > 28 || day1 < 1)
                        {
                            if (day1 > 28)
                                Console.WriteLine("This month can't be more than 28 days. Please enter a number between 1 and 28.");
                            else if (day1 < 0)
                                Console.WriteLine("You entered a negative value. Please enter a number between 1 and 28.");
                            else
                                Console.WriteLine("You entered an invalid value.Please try again.");
                        }

                    } while (day1 > 28 || day1 < 1);

                }

                Console.WriteLine("Please enter the second date: ");         // Second date information is requested. And for the entered values, the same operations applied for the first date are applied.

                do
                {
                    Console.Write("Year: ");
                    Year2 = Console.ReadLine();
                    int.TryParse(Year2, out Year_2);
                    if (Year_2 < 2015)
                    {
                        if (Year_2 < 0)
                            Console.WriteLine("You entered a negative value. Please enter a positive number.");
                        else if (Year_2 < 2015 && Year_2 > 0)
                            Console.WriteLine("The year you enter must be greater than 2015.");
                        else
                            Console.WriteLine("You entered an invalid value. Please try again.");
                    }
                } while (Year_2 < 2015);

                do
                {
                    Console.Write("Month: ");
                    month2 = Console.ReadLine();
                    month_2 = month2.ToUpper();

                    switch (month_2)
                    {
                        case "JANUARY": month__2 = 1; break;
                        case "FEBRUARY": month__2 = 2; break;
                        case "MARCH": month__2 = 3; break;
                        case "APRIL": month__2 = 4; break;
                        case "APRİL": month__2 = 4; break;
                        case "MAY": month__2 = 5; break;
                        case "JUNE": month__2 = 6; break;
                        case "JULY": month__2 = 7; break;
                        case "AUGUST": month__2 = 8; break;
                        case "SEPTEMBER": month__2 = 9; break;
                        case "OCTOBER": month__2 = 10; break;
                        case "NOVEMBER": month__2 = 11; break;
                        case "DECEMBER": month__2 = 12; break;
                        default: month__2 = -1; break;
                    }
                    if (month__2 == -1)
                        Console.WriteLine("You entered an invalid value. Please try again. (You must enter one of the 12 months in the Gregorian calendar.)");
                } while (month__2 < 1 || month__2 > 12);

                if (month__2 == 1 || month__2 == 3 || month__2 == 5 || month__2 == 7 || month__2 == 8 || month__2 == 10 || month__2 == 12)
                {
                    do
                    {
                        Console.Write("Day: ");
                        Day2 = Console.ReadLine();
                        int.TryParse(Day2, out day2);
                        if (day2 > 31 || day2 < 1)
                        {
                            if (day2 > 31)
                                Console.WriteLine("This month can't be more than 31 days. Please enter a number between 1 and 31.");
                            else if (day2 < 0)
                                Console.WriteLine("You entered a negative value. Please enter a number between 1 and 31.");
                            else
                                Console.WriteLine("You entered an invalid value.Please try again.");
                        }

                    } while (day2 > 31 || day2 < 1);
                }

                else if (month__2 == 4 || month__2 == 6 || month__2 == 9 || month__2 == 11)
                {
                    do
                    {
                        Console.Write("Day: ");
                        Day2 = Console.ReadLine();
                        int.TryParse(Day2, out day2);
                        if (day2 > 30 || day2 < 1)
                        {
                            if (day2 > 30)
                                Console.WriteLine("This month can't be more than 30 days. Please enter a number between 1 and 30.");
                            else if (day2 < 0)
                                Console.WriteLine("You entered a negative value. Please enter a number between 1 and 30.");
                            else
                                Console.WriteLine("You entered an invalid value.Please try again.");
                        }

                    } while (day2 > 30 || day2 < 1);
                }

                else if (month__2 == 2 && Year_2 % 4 == 0)
                {
                    do
                    {
                        Console.Write("Day: ");
                        Day2 = Console.ReadLine();
                        int.TryParse(Day2, out day2);
                        if (day2 > 29 || day2 < 1)
                        {
                            if (day2 > 29)
                                Console.WriteLine("This month can't be more than 29 days. Please enter a number between 1 and 29.");
                            else if (day2 < 0)
                                Console.WriteLine("You entered a negative value. Please enter a number between 1 and 29.");
                            else
                                Console.WriteLine("You entered an invalid value.Please try again.");
                        }

                    } while (day2 > 29 || day2 < 1);

                }

                else if (month__2 == 2 && Year_2 % 4 != 0)
                {
                    do
                    {
                        Console.Write("Day: ");
                        Day2 = Console.ReadLine();
                        int.TryParse(Day2, out day2);
                        if (day2 > 28 || day2 < 1)
                        {
                            if (day2 > 28)
                                Console.WriteLine("This month can't be more than 28 days. Please enter a number between 1 and 28.");
                            else if (day2 < 0)
                                Console.WriteLine("You entered a negative value. Please enter a number between 1 and 28.");
                            else
                                Console.WriteLine("You entered an invalid value.Please try again.");
                        }

                    } while (day2 > 28 || day2 < 1);

                }

                if (Year_1 == Year_2 && month__1 == month__2 && day1 == day2)             // If the same two dates are entered, an error message is given and the dates are requested again.
                    Console.WriteLine("You entered same dates. Please enter different dates.");
            } while (Year_1 == Year_2 && month__1 == month__2 && day1 == day2);


            if (Year_2 < Year_1)              // Here it is checked which date is first.
            {
                year1 = Year_2; Month1 = month__2; Day_1 = day2;
                year2 = Year_1; Month2 = month__1; Day_2 = day1;
            }
            else if (Year_1 < Year_2)
            {
                year1 = Year_1; Month1 = month__1; Day_1 = day1;
                year2 = Year_2; Month2 = month__2; Day_2 = day2;
            }
            else
            {
                if (month__1 < month__2)
                {
                    year1 = Year_1; Month1 = month__1; Day_1 = day1;
                    year2 = Year_2; Month2 = month__2; Day_2 = day2;
                }
                else if (month__2 < month__1)
                {
                    year1 = Year_2; Month1 = month__2; Day_1 = day2;
                    year2 = Year_1; Month2 = month__1; Day_2 = day1;
                }
                else
                {
                    if (day1 < day2)
                    {
                        year1 = Year_1; Month1 = month__1; Day_1 = day1;
                        year2 = Year_2; Month2 = month__2; Day_2 = day2;
                    }
                    else if (day2 < day1)
                    {
                        year1 = Year_2; Month1 = month__2; Day_1 = day2;
                        year2 = Year_1; Month2 = month__1; Day_1 = day1;
                    }
                }
            }

            do                                 // The user is prompted for a positive number value. This number determines how many skips the date will advance.
            {                                 // If an invalid value is entered, an error message is given and the number is requested again.
                Console.Write("At what intervals do you want the history to progress? : "); 
                string n1 = Console.ReadLine();
                int.TryParse(n1, out n);
                if (n <= 0)
                {
                    if (n < 0)
                        Console.WriteLine("You entered a negative value. Please enter a positive number.");
                    else
                        Console.WriteLine("You entered an invalid value. Please try again.");
                }
            } while (n <= 0);

            Console.Clear();

            static void Zellercongruence(int Day_1,           // Here, the Zeller algorithm is used. The Zeller algorithm determines which day of the week an entered date is.
                     int Month1, int year1)
            {
                if (Month1 == 1)
                {
                    Month1 = 13;
                    year1--;
                }
                if (Month1 == 2)
                {
                    Month1 = 14;
                    year1--;
                }
                int q = Day_1;
                int m = Month1;
                int k = year1 % 100;
                int j = year1 / 100;
                int h = q + 13 * (m + 1) / 5 + k + k / 4
                                         + j / 4 + 5 * j;
                h = h % 7;
                switch (h)
                {
                    case 0:
                        Console.WriteLine("Saturday");
                        break;

                    case 1:
                        Console.WriteLine("Sunday");
                        break;

                    case 2:
                        Console.WriteLine("Monday");
                        break;

                    case 3:
                        Console.WriteLine("Tuesday");
                        break;

                    case 4:
                        Console.WriteLine("Wednesday");
                        break;

                    case 5:
                        Console.WriteLine("Thursday");
                        break;

                    case 6:
                        Console.WriteLine("Friday");
                        break;
                }
            }

            if (year1 % 4 != 0)
            {                                                         // In order to calculate and print dates, day values ​​are determined according to the month. 
                switch (Month1)                                      // This applies to both dates. In addition, a separate calculation is made for leap years.
                {
                    case 1: totalDay = Day_1; break;
                    case 2: totalDay = Day_1 + 31; break;
                    case 3: totalDay = Day_1 + 59; break;
                    case 4: totalDay = Day_1 + 90; break;
                    case 5: totalDay = Day_1 + 120; break;
                    case 6: totalDay = Day_1 + 151; break;
                    case 7: totalDay = Day_1 + 181; break;
                    case 8: totalDay = Day_1 + 212; break;
                    case 9: totalDay = Day_1 + 243; break;
                    case 10: totalDay = Day_1 + 273; break;
                    case 11: totalDay = Day_1 + 304; break;
                    case 12: totalDay = Day_1 + 334; break;
                }
            }

            else if (year1 % 4 == 0)
            {
                switch (Month1)
                {
                    case 1: totalDay = Day_1; break;
                    case 2: totalDay = Day_1 + 31; break;
                    case 3: totalDay = Day_1 + 60; break;
                    case 4: totalDay = Day_1 + 91; break;
                    case 5: totalDay = Day_1 + 121; break;
                    case 6: totalDay = Day_1 + 152; break;
                    case 7: totalDay = Day_1 + 182; break;
                    case 8: totalDay = Day_1 + 213; break;
                    case 9: totalDay = Day_1 + 244; break;
                    case 10: totalDay = Day_1 + 274; break;
                    case 11: totalDay = Day_1 + 305; break;
                    case 12: totalDay = Day_1 + 335; break;
                }
            }

            if (year2 % 4 != 0)
            {                                                    // The "control day" (ctrlDay) used here is used to determine the point at which the program will stop while printing the date.
                switch (Month2)
                {
                    case 1: ctrlDay = Day_2; break;
                    case 2: ctrlDay = Day_2 + 31; break;
                    case 3: ctrlDay = Day_2 + 59; break;
                    case 4: ctrlDay = Day_2 + 90; break;
                    case 5: ctrlDay = Day_2 + 120; break;
                    case 6: ctrlDay = Day_2 + 151; break;
                    case 7: ctrlDay = Day_2 + 181; break;
                    case 8: ctrlDay = Day_2 + 212; break;
                    case 9: ctrlDay = Day_2 + 243; break;
                    case 10: ctrlDay = Day_2 + 273; break;
                    case 11: ctrlDay = Day_2 + 304; break;
                    case 12: ctrlDay = Day_2 + 334; break;
                }
            }

            else if (year2 % 4 == 0)
            {
                switch (Month2)
                {
                    case 1: ctrlDay = Day_2; break;
                    case 2: ctrlDay = Day_2 + 31; break;
                    case 3: ctrlDay = Day_2 + 60; break;
                    case 4: ctrlDay = Day_2 + 91; break;
                    case 5: ctrlDay = Day_2 + 121; break;
                    case 6: ctrlDay = Day_2 + 152; break;
                    case 7: ctrlDay = Day_2 + 182; break;
                    case 8: ctrlDay = Day_2 + 213; break;
                    case 9: ctrlDay = Day_2 + 244; break;
                    case 10: ctrlDay = Day_2 + 274; break;
                    case 11: ctrlDay = Day_2 + 305; break;
                    case 12: ctrlDay = Day_2 + 335; break;
                }
            }
                               
            if (Month1 == 1 || Month1 == 2)                      // If the date is to be printed from January or February, "WINTER" is printed here. Other seasonal information is in the following loop.
            {               
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("WINTER");
                Console.WriteLine("");
            }

            // Dates start to be printed here.
            while (year1 <= year2)                                 // This loop does the year check.                       
            {                                                     // If the first year and the second year are the same, month and day checks are made within the loop.
                if (totalDay <= 31 && totalDay > 0)
                {
                    while (totalDay <= 31)                       // The month is determined with the "totalDay" variable and the date is printed with the loop.
                    {
                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                        if ((year1 < year2 && Day_1 <= 31) || (year1 == year2 && totalDay <= ctrlDay))
                        {                                                                          // The ctrlDay variable determines whether to stop printing the date.
                            Console.Write(Day_1 + "." + "January" + "." + year1 + " ");
                            Console.ForegroundColor = ConsoleColor.Magenta;
                            Zellercongruence(Day_1, Month1, year1);
                            Day_1 += n;
                        }
                        totalDay += n;
                    }
                    Day_1 = totalDay - 31;                     // "Day_1" is reset and "Month1" is increased to move to the next month.
                    Month1++;
                    Console.WriteLine("");
                }

                if ((year1 % 4 == 0 && totalDay <= 60 && totalDay > 31) || (year1 % 4 != 0 && totalDay <= 59 && totalDay > 31))
                {                                                                                    // Again, a separate check is made for the leap year.            
                    while ((year1 % 4 == 0 && totalDay <= 60) || (year1 % 4 != 0 && totalDay <= 59))
                    {                                                                            
                        if ((year1 < year2) || (year1 == year2 && totalDay <= ctrlDay))
                        {
                            Console.ForegroundColor = ConsoleColor.DarkCyan;
                            if (year1 % 4 != 0 && Day_1 <= 28)
                            {
                                Console.Write(Day_1 + "." + "February" + "." + year1 + " ");
                                Console.ForegroundColor = ConsoleColor.Magenta;
                                Zellercongruence(Day_1, Month1, year1);
                                Day_1 += n;
                            }
                            else if (year1 % 4 == 0 && Day_1 <= 29)
                            {
                                Console.Write(Day_1 + "." + "February" + "." + year1 + " ");
                                Console.ForegroundColor = ConsoleColor.Magenta;
                                Zellercongruence(Day_1, Month1, year1);
                                Day_1 += n;

                            }
                        }
                        totalDay += n;
                    }
                    if (year1 % 4 != 0)
                        Day_1 = totalDay - 59;
                    else if (year1 % 4 == 0)
                        Day_1 = totalDay - 60;
                    Month1++;
                    Console.WriteLine("");
                }

                if ((Month1 == 3 || Month1 == 4 || Month1 == 5) && (totalDay > 59) && ((year1 == year2 && totalDay <= ctrlDay) || year1 < year2))
                {                                                                    // "SPRING" is printed when spring months starts.
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("SPRING");
                    Console.WriteLine("");
                }

                if ((year1 % 4 == 0 && totalDay <= 91 && totalDay > 60) || (year1 % 4 != 0 && totalDay <= 90 && totalDay > 59))
                {
                    while ((year1 % 4 == 0 && totalDay <= 91) || (year1 % 4 != 0 && totalDay <= 90))
                    {
                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                        if ((year1 < year2 && Day_1 <= 31) || (year1 == year2 && totalDay <= ctrlDay))
                        {
                            Console.Write(Day_1 + "." + "March" + "." + year1 + " ");
                            Console.ForegroundColor = ConsoleColor.Magenta;
                            Zellercongruence(Day_1, Month1, year1);
                            Day_1 += n;
                        }
                        totalDay += n;
                    }
                    if (year1 % 4 != 0)
                        Day_1 = totalDay - 90;
                    else if (year1 % 4 == 0)
                        Day_1 = totalDay - 91;
                    Month1++;
                    Console.WriteLine("");
                }

                if ((year1 % 4 == 0 && totalDay <= 121 && totalDay > 91) || (year1 % 4 != 0 && totalDay <= 120 && totalDay > 90))
                {
                    while ((year1 % 4 == 0 && totalDay <= 121) || (year1 % 4 != 0 && totalDay <= 120))
                    {
                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                        if ((year1 < year2 && Day_1 <= 30) || (year1 == year2 && totalDay <= ctrlDay))
                        {
                            Console.Write(Day_1 + "." + "April" + "." + year1 + " ");
                            Console.ForegroundColor = ConsoleColor.Magenta;
                            Zellercongruence(Day_1, Month1, year1);
                            Day_1 += n;
                        }
                        totalDay += n;
                    }
                    if (year1 % 4 != 0)
                        Day_1 = totalDay - 120;
                    else if (year1 % 4 == 0)
                        Day_1 = totalDay - 121;
                    Month1++;
                    Console.WriteLine("");
                }

                if ((year1 % 4 == 0 && totalDay <= 152 && totalDay > 121) || (year1 % 4 != 0 && totalDay <= 151 && totalDay > 120))
                {
                    while ((year1 % 4 == 0 && totalDay <= 152) || (year1 % 4 != 0 && totalDay <= 151))
                    {
                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                        if ((year1 < year2 && Day_1 <= 31) || (year1 == year2 && totalDay <= ctrlDay))
                        {
                            Console.Write(Day_1 + "." + "May" + "." + year1 + " ");
                            Console.ForegroundColor = ConsoleColor.Magenta;
                            Zellercongruence(Day_1, Month1, year1);
                            Day_1 += n;
                        }
                        totalDay += n;
                    }
                    if (year1 % 4 != 0)
                        Day_1 = totalDay - 151;
                    else if (year1 % 4 == 0)
                        Day_1 = totalDay - 152;
                    Month1++;
                    Console.WriteLine("");
                }

                if ((Month1 == 6 || Month1 == 7 || Month1 == 8) && (totalDay > 151) && ((year1 == year2 && totalDay <= ctrlDay) || year1 < year2))
                {                                                                       // "SUMMER" is printed when summer months starts.
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("SUMMER");
                    Console.WriteLine("");
                }

                if ((year1 % 4 == 0 && totalDay <= 182 && totalDay > 152) || (year1 % 4 != 0 && totalDay <= 181 && totalDay > 151))
                {
                    while ((year1 % 4 == 0 && totalDay <= 182) || (year1 % 4 != 0 && totalDay <= 181))
                    {
                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                        if ((year1 < year2 && Day_1 <= 30) || (year1 == year2 && totalDay <= ctrlDay))
                        {
                            Console.Write(Day_1 + "." + "June" + "." + year1 + " ");
                            Console.ForegroundColor = ConsoleColor.Magenta;
                            Zellercongruence(Day_1, Month1, year1);
                            Day_1 += n;
                        }
                        totalDay += n;
                    }
                    if (year1 % 4 != 0)
                        Day_1 = totalDay - 181;
                    else if (year1 % 4 == 0)
                        Day_1 = totalDay - 182;
                    Month1++;
                    Console.WriteLine("");
                }

                if ((year1 % 4 == 0 && totalDay <= 213 && totalDay > 182) || (year1 % 4 != 0 && totalDay <= 212 && totalDay > 181))
                {
                    while ((year1 % 4 == 0 && totalDay <= 213) || (year1 % 4 != 0 && totalDay <= 212))
                    {
                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                        if ((year1 < year2 && Day_1 <= 31) || (year1 == year2 && totalDay <= ctrlDay))
                        {
                            Console.Write(Day_1 + "." + "July" + "." + year1 + " ");
                            Console.ForegroundColor = ConsoleColor.Magenta;
                            Zellercongruence(Day_1, Month1, year1);
                            Day_1 += n;
                        }
                        totalDay += n;
                    }
                    if (year1 % 4 != 0)
                        Day_1 = totalDay - 212;
                    else if (year1 % 4 == 0)
                        Day_1 = totalDay - 213;
                    Month1++;
                    Console.WriteLine("");
                }

                if ((year1 % 4 == 0 && totalDay <= 244 && totalDay > 213) || (year1 % 4 != 0 && totalDay <= 243 && totalDay > 212))
                {
                    while ((year1 % 4 == 0 && totalDay <= 244) || (year1 % 4 != 0 && totalDay <= 243))
                    {
                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                        if ((year1 < year2 && Day_1 <= 31) || (year1 == year2 && totalDay <= ctrlDay))
                        {
                            Console.Write(Day_1 + "." + "August" + "." + year1 + " ");
                            Console.ForegroundColor = ConsoleColor.Magenta;
                            Zellercongruence(Day_1, Month1, year1);
                            Day_1 += n;
                        }
                        totalDay += n;
                    }
                    if (year1 % 4 != 0)
                        Day_1 = totalDay - 243;
                    else if (year1 % 4 == 0)
                        Day_1 = totalDay - 244;
                    Month1++;
                    Console.WriteLine("");
                }

                if ((Month1 == 9 || Month1 == 10 || Month1 == 11) && (totalDay > 243) && ((year1 == year2 && totalDay <= ctrlDay) || year1 < year2))
                {                                                                         // "AUTUMN" is printed when autumn months starts.
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("AUTUMN");
                    Console.WriteLine("");
                }

                if ((year1 % 4 == 0 && totalDay <= 274 && totalDay > 244) || (year1 % 4 != 0 && totalDay <= 273 && totalDay > 243))
                {
                    while ((year1 % 4 == 0 && totalDay <= 274) || (year1 % 4 != 0 && totalDay <= 273))
                    {
                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                        if ((year1 < year2 && Day_1 <= 30) || (year1 == year2 && totalDay <= ctrlDay))
                        {
                            Console.Write(Day_1 + "." + "September" + "." + year1 + " ");
                            Console.ForegroundColor = ConsoleColor.Magenta;
                            Zellercongruence(Day_1, Month1, year1);
                            Day_1 += n;
                        }
                        totalDay += n;
                    }
                    if (year1 % 4 != 0)
                        Day_1 = totalDay - 273;
                    else if (year1 % 4 == 0)
                        Day_1 = totalDay - 274;
                    Month1++;
                    Console.WriteLine("");
                }

                if ((year1 % 4 == 0 && totalDay <= 305 && totalDay > 274) || (year1 % 4 != 0 && totalDay <= 304 && totalDay > 273))
                {
                    while ((year1 % 4 == 0 && totalDay <= 305) || (year1 % 4 != 0 && totalDay <= 304))
                    {
                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                        if ((year1 < year2 && Day_1 <= 31) || (year1 == year2 && totalDay <= ctrlDay))
                        {
                            Console.Write(Day_1 + "." + "October" + "." + year1 + " ");
                            Console.ForegroundColor = ConsoleColor.Magenta;
                            Zellercongruence(Day_1, Month1, year1);
                            Day_1 += n;
                        }
                        totalDay += n;
                    }
                    if (year1 % 4 != 0)
                        Day_1 = totalDay - 304;
                    else if (year1 % 4 == 0)
                        Day_1 = totalDay - 305;
                    Month1++;
                    Console.WriteLine("");
                }

                if ((year1 % 4 == 0 && totalDay <= 335 && totalDay > 305) || (year1 % 4 != 0 && totalDay <= 334 && totalDay > 304))
                {
                    while ((year1 % 4 == 0 && totalDay <= 335) || (year1 % 4 != 0 && totalDay <= 334))
                    {
                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                        if ((year1 < year2 && Day_1 <= 30) || (year1 == year2 && totalDay <= ctrlDay))
                        {
                            Console.Write(Day_1 + "." + "November" + "." + year1 + " ");
                            Console.ForegroundColor = ConsoleColor.Magenta;
                            Zellercongruence(Day_1, Month1, year1);
                            Day_1 += n;
                        }
                        totalDay += n;
                    }
                    if (year1 % 4 != 0)
                        Day_1 = totalDay - 334;
                    else if (year1 % 4 == 0)
                        Day_1 = totalDay - 335;
                    Month1++;
                    Console.WriteLine("");
                }

                if (Month1 == 12 && totalDay > 334 && ((year1 == year2 && totalDay <= ctrlDay) || year1 < year2))
                {                                                                    // "WINTER" is printed when december starts.
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("WINTER");
                    Console.WriteLine("");
                }

                if ((year1 % 4 == 0 && totalDay <= 366 && totalDay > 335) || (year1 % 4 != 0 && totalDay <= 365 && totalDay > 334))
                {
                    while ((year1 % 4 == 0 && totalDay <= 366) || (year1 % 4 != 0 && totalDay <= 365))
                    {
                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                        if ((year1 < year2 && Day_1 <= 31) || (year1 == year2 && totalDay <= ctrlDay))
                        {
                            Console.Write(Day_1 + "." + "December" + "." + year1 + " ");
                            Console.ForegroundColor = ConsoleColor.Magenta;
                            Zellercongruence(Day_1, Month1, year1);
                            Day_1 += n;
                        }
                        totalDay += n;
                    }
                    if (year1 % 4 != 0)
                        Day_1 = totalDay - 365;
                    else if (year1 % 4 == 0)
                        Day_1 = totalDay - 366;              
                    totalDay = Day_1;
                    Console.WriteLine("");          // "Month1", "totalDay" and "Day_1" are reset and "year1" is incremented to start the loop. 
                    Month1 = 1;                    // The program stops when the second date is reached.
                }
                                        

                year1++;
            }

            Console.ReadLine();
