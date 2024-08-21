using Serenity.ComponentModel;
using System.ComponentModel;

namespace serenity_carsystem.Car.COM.Columns;

[ColumnsScript("Car.COM.car")]
[BasedOnRow(typeof(carRow), CheckNames = true)]
public class carColumns
{
    [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
    public int Id { get; set; }
    [EditLink]
    public string Carname { get; set; }
    public string Carcode { get; set; }
    public string Carnumplate { get; set; }
    public string Carcolor { get; set; }
    public string Carsympole { get; set; }
    public string Carmarka { get; set; }
}