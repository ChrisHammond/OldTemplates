<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Edit.ascx.cs" Inherits="$rootnamespace$$safeprojectname$.Edit" %>

<%@ Register TagPrefix="dnn" TagName="label" Src="~/controls/LabelControl.ascx" %>


<h2 id="dnnSitePanel-BasicSettings" class="dnnFormSectionHead"><a href="" class="dnnSectionExpanded"><%=LocalizeString("BasicSettings")%></a></h2>
<fieldset>
    <div class="dnnFormItem">
        <dnn:label ID="lblName" runat="server" />
        <asp:TextBox ID="txtName" runat="server" />
    </div>
    <div class="dnnFormItem">

        <dnn:label ID="lblDescription" runat="server"/>
        <asp:TextBox ID="txtDescription" runat="server" TextMode="MultiLine" Rows="5" Columns="20" />
    </div>
    <div class="dnnFormItem">
        <dnn:label ID="lblAssignedUser" runat="server" />
        <asp:DropDownList ID="ddlAssignedUser" runat="server" />
    </div>

    <div class="dnnFormItem">

        <asp:LinkButton ID="btnSubmit" runat="server"
            OnClick="btnSubmit_Click" resourcekey="btnSubmit" CssClass="dnnPrimaryAction" />
        <asp:LinkButton ID="btnCancel" runat="server"
            OnClick="btnCancel_Click" resourcekey="btnCancel" CssClass="dnnSecondaryAction" />

    </div>
</fieldset>


<script language="javascript" type="text/javascript">
    /*globals jQuery, window, Sys */
    (function ($, Sys) {
        function dnnBasicSettings() {
            $('#dnnSitePanel-BasicSettings').dnnPanels();
            $('#dnnSitePanel-BasicSettings .dnnFormExpandContent a').dnnExpandAll({ expandText: '<%=Localization.GetString("ExpandAll", LocalResourceFile)%>', collapseText: '<%=Localization.GetString("CollapseAll", LocalResourceFile)%>', targetArea: '#dnnSitePanel-BasicSettings' });
        }

        $(document).ready(function () {
            dnnBasicSettings();
            Sys.WebForms.PageRequestManager.getInstance().add_endRequest(function () {
                dnnBasicSettings();
            });
        });

    }(jQuery, window.Sys));
</script>