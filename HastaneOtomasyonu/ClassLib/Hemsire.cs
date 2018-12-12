﻿using HastaneOtomasyonu.Class_Lib;

namespace HastaneOtomasyonu.ClassLib
{
    public class Hemsire : Kisi, IMaasAlabilir
    {
        string _maas;
        public DoktorBranslari HemsireBrans { get; }
        public string Maas
        { get => this._maas;
            set
            {
                _maas = value;
            }
        }
    }
}