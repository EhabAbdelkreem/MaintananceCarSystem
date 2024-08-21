using Serenity.ComponentModel;

namespace serenity_carsystem.Car.COM.Forms;

[FormScript("Car.COM.car")]
[BasedOnRow(typeof(carRow), CheckNames = true)]
public class carForm
{
    public string Carname { get; set; }
    public string Carcode { get; set; }
    public string Carnumplate { get; set; }
    public string Carcolor { get; set; }
    public string Carsympole { get; set; }
    public string Carmarka { get; set; }
}