import { ColumnsBase, fieldsProxy } from "@serenity-is/corelib";
import { Column } from "@serenity-is/sleekgrid";
import { carRow } from "./COM.carRow";

export interface carColumns {
    Id: Column<carRow>;
    Carname: Column<carRow>;
    Carcode: Column<carRow>;
    Carnumplate: Column<carRow>;
    Carcolor: Column<carRow>;
    Carsympole: Column<carRow>;
    Carmarka: Column<carRow>;
}

export class carColumns extends ColumnsBase<carRow> {
    static readonly columnsKey = 'Car.COM.car';
    static readonly Fields = fieldsProxy<carColumns>();
}