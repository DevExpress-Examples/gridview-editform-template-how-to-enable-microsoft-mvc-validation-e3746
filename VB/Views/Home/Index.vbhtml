﻿<script type="text/javascript">
    function UpdateGridView() {
        InitializeMVCValidationScript();

        var form = GetEditableForm();
        if (form.validationCallbacks[0]())
            grid.UpdateEdit();
    }
    function InitializeMVCValidationScript() {
        var validationRulesScript = GetEditableForm().nextSibling;
        if (validationRulesScript && !validationRulesScript.executed) {
            validationRulesScript.executed = true;
            eval(validationRulesScript.text);
            Sys.Mvc.FormContext._Application_Load();
        }
    }
    function GetEditableForm() {
        return document.getElementById("frmProduct");
    }
</script>
@Html.Action("GridViewPartial", "Home")
