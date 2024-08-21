using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System.ComponentModel;

namespace serenity_carsystem.Car.COM;

[ConnectionKey("Default"), Module("Car.COM"), TableName("cartable")]
[DisplayName("Car"), InstanceName("Car")]
[ReadPermission("car")]
[ModifyPermission("car")]
[ServiceLookupPermission("car")]
public sealed class carRow : Row<carRow.RowFields>, IIdRow, INameRow
{
    [DisplayName("Id"), Identity, IdProperty]
    public int? Id { get => fields.Id[this]; set => fields.Id[this] = value; }

    [DisplayName("Carname"), Column("carname"), Size(50), QuickSearch, NameProperty]
    public string Carname { get => fields.Carname[this]; set => fields.Carname[this] = value; }

    [DisplayName("Carcode"), Column("carcode"), Size(50)]
    public string Carcode { get => fields.Carcode[this]; set => fields.Carcode[this] = value; }

    [DisplayName("Carnumplate"), Column("carnumplate"), Size(50)]
    public string Carnumplate { get => fields.Carnumplate[this]; set => fields.Carnumplate[this] = value; }

    [DisplayName("Carcolor"), Column("carcolor"), Size(50)]
    public string Carcolor { get => fields.Carcolor[this]; set => fields.Carcolor[this] = value; }

    [DisplayName("Carsympole"), Column("carsympole"), Size(50)]
    public string Carsympole { get => fields.Carsympole[this]; set => fields.Carsympole[this] = value; }

    [DisplayName("Carmarka"), Column("carmarka"), Size(50)]
    public string Carmarka { get => fields.Carmarka[this]; set => fields.Carmarka[this] = value; }

    public class RowFields : RowFieldsBase
    {
        public Int32Field Id;
        public StringField Carname;
        public StringField Carcode;
        public StringField Carnumplate;
        public StringField Carcolor;
        public StringField Carsympole;
        public StringField Carmarka;

    }
}