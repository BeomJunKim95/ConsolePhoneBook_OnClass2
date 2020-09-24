﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolePhoneBook
{
    public class PhoneInfo : IComparable
    {
        string name;   //필수
        string phoneNumber;  //필수
        string birth;  //선택

        public string Name 
        { 
            get { return name; }
        }
        public string Phone
        {
            get { return phoneNumber; }
        }

        public PhoneInfo(string name, string phoneNumber)
        {
            this.name = name;
            this.phoneNumber = phoneNumber;
            this.birth = null;
        }

        public PhoneInfo(string name, string phoneNumber, string birth)
        {
            this.name = name;
            this.phoneNumber = phoneNumber;
            this.birth = birth;
        }        

        public virtual void ShowPhoneInfo()
        {
            Console.Write("name: " + this.name);
            Console.Write("\t phone: " + this.phoneNumber);
            if (birth != null)
                Console.Write("\t birth: " + this.birth);
        }

        public override string ToString()
        {
            return $"name:{name}\t phone:{phoneNumber}\t birth:{birth}";
        }

		public int CompareTo(object obj)
		{
            PhoneInfo other = (PhoneInfo)obj; //인자가 obj기 때문에 obj를 바꿀 클래스타입으로 형변환 해주고 인스턴스를 생성
            //if (this.name.CompareTo(other.name) == 1) //문자열은 크다작다 연산자가 없음,  앞에게 더크면 1
            //    return 1;
            //else if (this.name.CompareTo(other.name) == -1)
            //    return -1;
            //else
            //    return 0;

            return this.name.CompareTo(other.name); // 한줄

        }
	}

    public class PhoneUnivInfo : PhoneInfo
    {
        string major;
        int year;

        public PhoneUnivInfo(string name, string phonenumber, string birth, string major, int year)
            :base(name, phonenumber, birth) 
        {
            this.major = major;
            this.year = year;
        }

        public override void ShowPhoneInfo()
        {
            base.ShowPhoneInfo();
            Console.Write($"major:{major}\t year:{year}");
        }

        public override string ToString()
        {
            return $"{base.ToString()}\t major:{major}\t year:{year}";
        }
    }

    public class PhoneCompanyInfo : PhoneInfo
    {
        string company;

        public PhoneCompanyInfo(string name, string phonenumber, string birth, string company)
                               :base(name, phonenumber, birth)
        {
            this.company = company;
        }

        public override void ShowPhoneInfo()
        {
            base.ShowPhoneInfo();
            Console.Write($"company:{company}");
        }

        public override string ToString()
        {
            return $"{base.ToString()}\t company:{company}";
        }
    }
}