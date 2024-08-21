﻿import { EntityDialog, HtmlContentEditor } from "@serenity-is/corelib";
import { Authorization, Config, ErrorHandling } from "@serenity-is/corelib";
import { siteLanguageList } from "./Helpers/LanguageList";

Config.rootNamespaces.push('serenity_carsystem');
EntityDialog.defaultLanguageList = siteLanguageList;
HtmlContentEditor.CKEditorBasePath = "~/Serenity.Assets/Scripts/ckeditor/";

if ($.fn['colorbox']) {
    $.fn['colorbox'].settings.maxWidth = "95%";
    $.fn['colorbox'].settings.maxHeight = "95%";
}

window.onerror = ErrorHandling.runtimeErrorHandler;