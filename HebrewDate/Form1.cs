using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace HebrewDate
{
    public partial class Form1 : Form
    {
        XmlDocument xmlDocument;
        //נתיב לקובץ
        string pathName = Directory.GetCurrentDirectory() + "\\QueriesDate.xml";
        public Form1()
        {
            InitializeComponent();
            xmlDocument = new XmlDocument();
            //מציאת הקובץ ואם לא נמצא אז יצירת חדש
            if (File.Exists(pathName))
            {
                try
                {
                    xmlDocument.Load(pathName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading XML file: " + ex.Message);
                }
            }
            else
            {
                XmlNode root = xmlDocument.CreateElement("Queries");
                xmlDocument.AppendChild(root);
                xmlDocument.Save(pathName);
            }
        }
        //פונקציה בעת לחיצה על כפתור יצירת תאריך
        private void btnCreateDate_Click(object sender, EventArgs e)
        {
            //בדיקה שכל הנתונים הוזנו
            if (cmbDay.Text == "" || cmbDayMonth.Text == "" || cmbMonth.Text == "" || cmbYear.Text == "")
            {
                MessageBox.Show("חסרים פרטים עבור התאריך");
                return;
            }
            //הבאת היום בשבוע בפורמט המתאים מפונקציה
            string day = findDay();
            //בדיקה אם חזר סטרינג מלא
            if (day == "")
            {
                return;
            }
            //הבאת יום בחודש והחודש בפורמט המתאים מפונקציה
            string dayMonthAndMonth = findDayMonthAndMonth();
            //בדיקה אם חזר סטרינג מלא
            if (dayMonthAndMonth == "")
            {
                return;
            }
            //הבאת השנה בפורמט המתאים מפונקציה
            string year = findYear();
            //בדיקה אם חזר סטרינג מלא
            if (year == "")
            {
                return;
            }
            //יצירת סטרינג ארוך שמכיל את כל התאריך עם הפורמט המתאים
            string result = day + " " + dayMonthAndMonth + " " + year;
            //הצגת התאריך על המסך
            lblFinalHebrewDate.Text = result;
            //הוספת הבקשה והתוצאה לאקסמל
            AddQuery(result);
            //ניקוי השדות
            cmbDay.Text = "";
            cmbDayMonth.Text = "";
            cmbMonth.Text = "";
            cmbYear.Text = "";
        }
        //פונקציה למציאת היום ושינוי פורמט הכתיבה
        private string findDay()
        {
            string day = "";
            switch (cmbDay.Text)
            {
                case "ראשון":
                    day = "באחד בשבת";
                    break;
                case "שני":
                    day = "בשני בשבת";
                    break;
                case "שלישי":
                    day = "בשלישי בשבת";
                    break;
                case "רביעי":
                    day = "ברביעי בשבת";
                    break;
                case "חמישי":
                    day = "בחמישי בשבת";
                    break;
                case "שישי":
                    day = "בששי בשבת";
                    break;
            }
            if (day == "")
            {
                MessageBox.Show("יום בשבוע לא חוקי");
            }
            return day; 
        }
        //פונקציה שמחזירה את הימים בחודש ואת החודשים לפי הפורמט
        private string findDayMonthAndMonth()
        {
            //יצירת מערך סטרינגים לפי הימים בחודש חוץ מהיום השלושים
            string[] DayMonthArry = new string[29];
            DayMonthArry[0] = "יום אחד לירח";
            DayMonthArry[1] = "שני ימים לירח";
            DayMonthArry[2] = "שלשה ימים לירח";
            DayMonthArry[3] = "ארבעה ימים לירח";
            DayMonthArry[4] = "חמשה ימים לירח";
            DayMonthArry[5] = "ששה ימים לירח";
            DayMonthArry[6] = "שבעה ימים לירח";
            DayMonthArry[7] = "שמנה ימים לירח";
            DayMonthArry[8] = "תשעה ימים לירח";
            DayMonthArry[9] = "עשרה ימים לירח";
            DayMonthArry[10] = "אחד עשר לירח";
            DayMonthArry[11] = "שנים עשר לירח";
            DayMonthArry[12] = "שלשה עשר לירח";
            DayMonthArry[13] = "ארבעה עשר לירח";
            DayMonthArry[14] = "חמשה עשר לירח";
            DayMonthArry[15] = "ששה עשר לירח";
            DayMonthArry[16] = "שבעה עשר לירח";
            DayMonthArry[17] = "שמנה עשר לירח";
            DayMonthArry[18] = "תשעה עשר לירח";
            DayMonthArry[19] = "עשרים יום לירח";
            DayMonthArry[20] = "אחד ועשרים יום לירח";
            DayMonthArry[21] = "שנים ועשרים יום לירח";
            DayMonthArry[22] = "שלשה ועשרים יום לירח";
            DayMonthArry[23] = "ארבעה ועשרים יום לירח";
            DayMonthArry[24] = "חמשה ועשרים יום לירח";
            DayMonthArry[25] = "ששה ועשרים יום לירח";
            DayMonthArry[26] = "שבעה ועשרים יום לירח";
            DayMonthArry[27] = "שמנה ועשרים יום לירח";
            DayMonthArry[28] = "תשעה ועשרים יום לירח";
            //כניסה לתריי וקאצ בגלל ההפיכה של המספר לאינט
            try
            {
                //הפיכת השדה של היום מסטרינג למספר
                int DayMonth = int.Parse(cmbDayMonth.Text);
                //בדיקה אם המספר בין אחד לשלושים
                if (DayMonth < 1 || DayMonth > 30)
                {
                    MessageBox.Show("יש להכניס יום בחודש חוקי");
                    return "";
                }
                //הבאת החודש
                string month = findMonth();
                if (month == "")
                {
                    return "";
                }
                //אם המספר קטן מ30
                if (DayMonth < 30)
                {   
                    //מחזיר את הסטרינג של היום עם החודש
                    return DayMonthArry[DayMonth - 1] + " " + month;
                }
                //למקרה ראש חודש 30
                return $"יום שלשים לחודש {month} שהוא ראש חודש {findMonth(true)} ";
            }
            catch
            {
                MessageBox.Show("יש להכניס רק מספרים לימים בחודש");
                return "";
            }
        }
        //פונקציה בשימוש הפונקציה הקודמת למציאת החודש כולל אם זה היום השלושים
        private string findMonth(bool if30 = false)
        {
            if (cmbMonth.Text == "")
            {
                MessageBox.Show("לא הוכנס חודש");
                return "";
            }
            //יצירת מערך סטרינגים של חודשים
            string[] MonthArry = new string[14];
            MonthArry[0] = "תשרי";
            MonthArry[1] = "מרחשון";
            MonthArry[2] = "כסלו";
            MonthArry[3] = "טבת";
            MonthArry[4] = "שבט";
            MonthArry[5] = "אדר";
            MonthArry[6] = "אדר הראשון";
            MonthArry[7] = "אדר השני";
            MonthArry[8] = "ניסן";
            MonthArry[9] = "אייר";
            MonthArry[10] = "סיון";
            MonthArry[11] = "תמוז";
            MonthArry[12] = "אב";
            MonthArry[13] = "אלול";
            //בדיקה עם החודש שהוזן בתוך מערכת החודשים
            if (MonthArry.Contains(cmbMonth.Text))
            {
                //למקרה בו היום הוא שלושים מחזיר את החודש הבא
                if (if30)
                {
                    int count = 0;
                    foreach(string str in MonthArry)
                    {
                        if (count == 1)
                        {
                            return str;
                        }
                        if(str == cmbMonth.Text)
                        {
                            count = 1;
                        }
                    }
                    //בחודש האחרון הוא יחזיר את החודש הראשון
                    return MonthArry[0];
                }
                //אם לא מדובר בחודש שלושים הוא יחזיר את החודש
                return cmbMonth.Text;
            }
            //אם החודש לא קיים במערך
            MessageBox.Show("חודש שהוכנס לא תקין");
            return "";
        }
        //פונקציה שמחזירה את השנה בפורמט המתאים
        private string findYear()
        {
            string year = "";
            switch (cmbYear.Text)
            {
                case "תשפ''ד":
                    year = "שנת חמשת אלפים ושבע מאות ושמנים וארבע לבריאת העולם";
                    break;
                case "תשפ''ה":
                    year = "שנת חמשת אלפים ושבע מאות ושמנים וחמש לבריאת העולם";
                    break;
                case "תשפ''ו":
                    year = "שנת חמשת אלפים ושבע מאות ושמנים ושש לבריאת העולם";
                    break;
                case "תשפ''ז":
                    year = "שנת חמשת אלפים ושבע מאות ושמנים ושבע לבריאת העולם";
                    break;
                case "תשפ''ח":
                    year = "שנת חמשת אלפים ושבע מאות ושמנים ושמנה לבריאת העולם";
                    break;
                case "תשפ''ט":
                    year = "שנת חמשת אלפים ושבע מאות ושמנים ותשע לבריאת העולם";
                    break;
                case "תש''צ":
                    year = "שנת חמשת אלפים ושבע מאות ותשעים לבריאת העולם";
                    break;
                case "תשצ''א":
                    year = "שנת חמשת אלפים ושבע מאות ותשעים ואחד לבריאת העולם";
                    break;
                case "תשצ''ב":
                    year = "שנת חמשת אלפים ושבע מאות ותשעים ושתים לבריאת העולם";
                    break;
                case "תשצ''ג":
                    year = "שנת חמשת אלפים ושבע מאות ותשעים ושלש לבריאת העולם";
                    break;
            }
            if (year == "")
            {
                MessageBox.Show("השנה לא חוקית או לא בטווח המערכת");
            }
            return year;
        }
        //פונקציה להוספת השאילתה  לאקסמל
        private void AddQuery(string resul)
        {
            //יצירת אלמנטים
            XmlNode query = xmlDocument.CreateElement("Query");
            XmlNode day = xmlDocument.CreateElement("Day");
            XmlNode dayMonth = xmlDocument.CreateElement("DayMonth");
            XmlNode month = xmlDocument.CreateElement("Month");
            XmlNode year = xmlDocument.CreateElement("Year");
            XmlNode result = xmlDocument.CreateElement("Result");
            //הכנסת ערכים לאלמנטים
            day.InnerText = cmbDay.Text;
            dayMonth.InnerText = cmbDayMonth.Text;
            month.InnerText = cmbMonth.Text;
            year.InnerText = cmbYear.Text;
            result.InnerText = resul;
            //הכנסת האלמנטים של השאילתה לתוך אלמנט אחד
            query.AppendChild(day);
            query.AppendChild(dayMonth);
            query.AppendChild(month);
            query.AppendChild(year);
            query.AppendChild(result);
            //הכנסת האלמנט לתוך האלמנט הראשי של האקסמל ושמירה
            xmlDocument.FirstChild.AppendChild(query);
            xmlDocument.Save(pathName);
        }
    }
}
