//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Байбаков_Автосервис
{
    using System;
    using System.Collections.Generic;
    
    public partial class Service
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string MainImagePath { get; set; }
        public int Duration { get; set; }
        public decimal Cost { get; set; }
        public Nullable<double> Discount { get; set; }

        public int DiscountInt
        {
            get
            {
                if (this.Discount != null)
                {
                    return Convert.ToInt32(Discount * 100);
                }
                else
                {
                    return 0;
                }
            }
            set
            {
                this.Discount = Convert.ToDouble(value) / 100;
            }
        }
        public string Description { get; set; }
    }
}
