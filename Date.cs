// public class Date
// {
//     private int day;
//     private int month;
//     private int year;

//     public Date()
//     {
//         day = 1;
//         month = 1;
//         year = 2000;
//     }

//     public Date(int day, int month, int year)
//     {
//         this.day = day;
//         this.month = month;
//         this.year = year;
//     }

//     public void SetDay(int day)
//     {
//         this.day = day;
//     }

//     public void SetMonth(int month)
//     {
//         this.month = month;
//     }

//     public void SetYear(int year)
//     {
//         this.year = year;
//     }

//     public int GetDay()
//     {
//         return day;
//     }

//     public int GetMonth()
//     {
//         return month;
//     }

//     public int GetYear()
//     {
//         return year;
//     }

//     public void SetDate(int day, int month, int year)
//     {
//         this.day = day;
//         this.month = month;
//         this.year = year;
//     }

//     public override string ToString()
//     {
//         return day.ToString("D2") + "/" +
//                month.ToString("D2") + "/" +
//                year.ToString("D4");
//     }
// }