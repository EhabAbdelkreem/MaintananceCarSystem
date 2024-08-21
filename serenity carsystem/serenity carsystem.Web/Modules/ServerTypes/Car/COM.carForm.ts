import { StringEditor, PrefixedContext, initFormType } from "@serenity-is/corelib";

export interface carForm {
    Carname: StringEditor;
    Carcode: StringEditor;
    Carnumplate: StringEditor;
    Carcolor: StringEditor;
    Carsympole: StringEditor;
    Carmarka: StringEditor;
}

export class carForm extends PrefixedContext {
    static readonly formKey = 'Car.COM.car';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!carForm.init)  {
            carForm.init = true;

            var w0 = StringEditor;

            initFormType(carForm, [
                'Carname', w0,
                'Carcode', w0,
                'Carnumplate', w0,
                'Carcolor', w0,
                'Carsympole', w0,
                'Carmarka', w0
            ]);
        }
    }
}