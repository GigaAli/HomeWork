using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Product
{
    public int ID { get; set; }
    public string Name { get; set; }
    public DateTime ProductionDate { get; set; }
    public DateTime ExpiresOn { get; set; }
    public double BruttoWeight { get; set; }
    public double NettoWeight { get; set; }
}