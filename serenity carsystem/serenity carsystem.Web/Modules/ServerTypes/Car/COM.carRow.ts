import { fieldsProxy } from "@serenity-is/corelib";

export interface carRow {
    Id?: number;
    Carname?: string;
    Carcode?: string;
    Carnumplate?: string;
    Carcolor?: string;
    Carsympole?: string;
    Carmarka?: string;
}

export abstract class carRow {
    static readonly idProperty = 'Id';
    static readonly nameProperty = 'Carname';
    static readonly localTextPrefix = 'Car.COM.car';
    static readonly deletePermission = 'car';
    static readonly insertPermission = 'car';
    static readonly readPermission = 'car';
    static readonly updatePermission = 'car';

    static readonly Fields = fieldsProxy<carRow>();
}