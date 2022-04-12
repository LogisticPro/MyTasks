using System;
using System.Collections.Generic;
using System.Text;

namespace HomeTask_7
{
    internal class Passport
    {
        public Passport(int serial, int number, string issued, DateTime issuedDate)
        {
            Serial = serial;
            Number = number;
            Issued = issued;
            IssuedDate = issuedDate;
        }

        private int _serial;
        private int _number;
        private string _issued;
        private DateTime _issuedDate = new DateTime();
        private readonly DateTime CountryFormationTime = new DateTime(1991, 12, 25);

        public int Serial
        {
            get
            {
                return _serial;
            }
            set
            {
                if (value >= 0 && value <= 9999)
                {
                    _serial = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
        }
        public string SerialStr
        {
            get
            {
                return string.Format("{0:d4}", _serial);
            }
        }

        public int Number
        {
            get
            {
                return _number;
            }
            set
            {
                if (value >= 0 && value <= 999999)
                {
                    _number = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
        }
        public string NumberStr
        {
            get
            {
                return string.Format("{0:d6}", _number);
            }
        }

        public string Issued
        {
            get { return _issued; }
            set
            {
                if (value != null)
                {
                    _issued = value;
                }
                else
                {
                    throw new NullReferenceException();
                }
            }
        }
        public DateTime IssuedDate
        {
            get
            {
                return _issuedDate;
            }
            set
            {
                if (value >= CountryFormationTime && value <= DateTime.Now)
                {
                    _issuedDate = value;
                }
                else
                {
                    throw new Exception("Введите корректрую дату издания пасспорта!");
                }
            }
        }

        public bool IsActive
        {
            get
            {
                if ((DateTime.Now.Year - IssuedDate.Year) >= 10)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }
    }
}
