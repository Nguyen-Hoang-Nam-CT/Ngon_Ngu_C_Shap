using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai6
{
    class ThoiGian
    {
        private int ngay, thang, nam, gio, phut, giay;
        public ThoiGian()
        {
            ngay = 20;
            thang = 9;
            nam = 2014;
            gio = 10;
            phut = 30;
            giay = 40;
        }
        public ThoiGian(int Date, int Month, int Year, int Hour, int Minute, int Second)
        {
            ngay = Date;
            thang = Month;
            nam = Year;
            gio = Hour;
            phut = Minute;
            giay = Second;
        }
        public ThoiGian(int Date, int Month, int Year)
        {
            ngay = Date;
            thang = Month;
            nam = Year;
        }
        public ThoiGian(ThoiGian temp)
        {
            ngay = temp.ngay;
            thang = temp.thang;
            nam = temp.nam;
            gio = temp.gio;
            phut = temp.phut;
            giay = temp.giay;
        }
        public ThoiGian(System.DateTime tg)
        {
            nam = tg.Year;
            thang = tg.Month;
            ngay = tg.Day;
            gio = tg.Hour; 
            phut = tg.Minute;
            giay = tg.Second;
        }
        public void showTime()
        {
            Console.Write("\n{0}/{1}/{2} : {3}:{4}:{5}", ngay,thang,nam, gio, phut, giay);
        }
    }
}
