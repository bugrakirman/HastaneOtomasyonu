﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace HastaneOtomasyonu.Class_Lib
{


    public abstract class Kisi
    {

        private string _ad, _soyad, _email, _telefon, _tckn;
        Regex rgx = new Regex(@"^[a-zA-Z]*$");
        Regex rgxEmail = new Regex(@"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$");
        Regex rgxTelefon = new Regex(@"^[0-9]*$");


        public string Ad
        {
            get => this._ad;

            set
            {
                if (!rgx.IsMatch(value))
                {
                    throw new Exception("Adınız yalnızca harflerden oluşmalıdır.");
                }

                _ad = value.Substring(0, 1).ToUpper() + value.Substring(1).ToLower();
            }
        }
        public string Soyad
        {
            get => this._soyad;
            set
            {
                if (!rgx.IsMatch(value))
                {
                    throw new Exception("Adınız yalnızca harflerden oluşmalıdır.");
                }

                _soyad = value.Substring(0, 1).ToUpper() + value.Substring(1).ToLower();
            }
        }
        public string Email
        {
            get => _email;
            set
            {
                if (!rgxEmail.IsMatch(value))
                {
                    throw new Exception("Mail adresini doğru giriniz.");
                }

                _email = value;
            }
        }
        public string Telefon
        {
            get => _telefon; 
            set
            {
                if (!rgxTelefon.IsMatch(value))
                {
                    throw new Exception("Telefon numarası yalnızca rakamlardan oluşmalıdır.");
                }

                if(value.Length<11 || value.Length > 11)
                {
                    throw new Exception("Telefon numarası 11 haneli olmalıdır.");
                }

                if (value.Substring(0, 1) != "0")
                {
                    throw new Exception("Telefon numarası '0' ile başlamalı");
                }

                _telefon = value;
            }
        }
        public string TCKN
        {
            get => _tckn;
            set
            {
                if(value.Length != 11)
                {
                    throw new Exception("TCKN 11 haneli olmalıdır.");
                }
                if (!rgxTelefon.IsMatch(value))
                {
                    throw new Exception("TCKN sadece rakamlardan oluşmalıdır.");
                }

                _tckn = value;
            }
        }

    }
}