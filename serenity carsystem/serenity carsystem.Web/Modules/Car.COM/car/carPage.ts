import { initFullHeightGridPage } from '@serenity-is/corelib';
import { carGrid } from './carGrid';

export default function pageInit() {
    initFullHeightGridPage(new carGrid($('#GridDiv')).element);
}