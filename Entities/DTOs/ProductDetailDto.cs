using Core;
using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class ProductDetailDto: IDto //BİRBİRLERİ İLE İLİŞKİLİ OLDUKLARI TABLOLARIN VERİLERİNE ULAŞMAK İÇİN OBJE OLUŞTURDUK ,
                                        //BU SAYEDE ÖRNEĞİN PRODUCT ÜZERİNDE ÇALIŞIRKEN ORADAKİ BAĞLANTILI CATEGORYID SAYESİNDE
                                        //CATEGORY NAME DE GİDECEĞİZ
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string CategoryName { get; set; }
        public short UnitsInStock { get; set; }
    }
}
