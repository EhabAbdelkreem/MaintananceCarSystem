import { carForm, carRow, carService } from '@/ServerTypes/Car.COM';
import { Decorators, EntityDialog } from '@serenity-is/corelib';

@Decorators.registerClass('serenity_carsystem.Car.COM.carDialog')
export class carDialog extends EntityDialog<carRow, any> {
    protected getFormKey() { return carForm.formKey; }
    protected getRowDefinition() { return carRow; }
    protected getService() { return carService.baseUrl; }

    protected form = new carForm(this.idPrefix);
}