import { carColumns, carRow, carService } from '@/ServerTypes/Car.COM';
import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { carDialog } from './carDialog';

@Decorators.registerClass('serenity_carsystem.Car.COM.carGrid')
export class carGrid extends EntityGrid<carRow, any> {
    protected getColumnsKey() { return carColumns.columnsKey; }
    protected getDialogType() { return carDialog; }
    protected getRowDefinition() { return carRow; }
    protected getService() { return carService.baseUrl; }

    constructor(container: JQuery) {
        super(container);
    }
}