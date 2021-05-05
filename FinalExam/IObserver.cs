﻿//Written by Jiameng Zhou
// 05/02/2021
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalExam
{
    public interface IObserver
    {
        void React(List<Item> aItemForSale, List<Item> aItemWanted);

        void BuyItem(Item buyItem, int quantityBuy);


    }
}
