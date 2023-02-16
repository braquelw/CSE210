using System;

class Program
{
    static void Main(string[] args)
    {
        Address a1 = new Address("4890 Whitaker Rd", "Chubbuck", "ID", "83202");
        string address1 = a1.GetAddress();
        LectureEvent e1 = new LectureEvent("Women's Conference", "an event that uplifts and inspires women", "March 4, 2023", "10:00am - Noon", $"{address1}", "Shawna Morrissey", 300);

        Address a2 = new Address("10802 S UT-165", "Paradise", "UT", "84328");
        string address2 = a2.GetAddress();
        ReceptionEvent e2 = new ReceptionEvent("Brendan & Tiana", "wedding and reception for B & T", "October 16, 2023", "10:00am - 7:00pm", $"{address2}", "brendan@gmail.com");

        Address a3 = new Address("4025 S Hwy 89-91", "Wellsville", "UT", "84339");
        string address3 = a3.GetAddress();
        OutdoorEvent e3 = new OutdoorEvent("Baby Animal Days", "an outdoor event for all ages", "April 5-8", "10:00am - 6:00pm", $"{address3}", "Overcast");

        // Short Descriptions
        e1.ShortDescription();
        e2.ShortDescription();
        e3.ShortDescription();

        // Standard Details
        e1.StandardDetails();
        e2.StandardDetails();
        e3.StandardDetails();

        // Full Details
        e1.LectureFullDetails();
        e2.ReceptionFullDetails();
        e3.OutdoorFullDetails();
    }
}