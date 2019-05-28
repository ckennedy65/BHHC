<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="BHHC_Standard._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="content">
        <table border="0" cellpadding="0" cellspacing="0" width="100%" style="table-layout: fixed;">
            <tr>
                <td class="text_right">
                    Create Rationale:&nbsp;
                </td>
                <td class="text_left" style="width:265px"><input id="tbRationale" type="text" class="textbox" style="width: 250px"/></td>
                <td class="text_left"><input id="btnAdd" type="button" class="ui-button ui-widget ui-corner-all" value="ADD"/></td>
            </tr>
            <tr>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="text_left" colspan="3">
                    <asp:Button runat="server" CssClass="ui-button ui-widget ui-corner-all" Text="DISPLAY" OnClick="btnDisplay_Click"  />
                </td>
            </tr>
            <tr>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td colspan="3">Reasons To Join Berkshire Hathaway Homestate Companies</td>
            </tr>
            <tr>
                <td colspan="3">
                    <asp:GridView runat="server" id="dgRationales" AutoGenerateColumns="True" ForeColor="#FFFFFF" GridLines="None" 
                                  Font-Names="Verdana" Font-Size="12px" BorderStyle="Solid" BorderWidth="1px" BorderColor="Navy" Width="100%">
                        <%--<Columns>
                        <asp:BoundField HeaderText="RATIONALE" DataField="Item"/>
                    </Columns>--%>
                    </asp:GridView>   
                </td>
            </tr>
        </table>
    </div>
    <script type="text/javascript">
        var rationale = $('#tbRationale');
        $('#btnAdd').click(function () {
            var jsonText = JSON.stringify({ rationale : rationale.val() });
            $.ajax({
                type: "POST",
                url: 'Default.aspx/AddRationale',
                data: jsonText,
                contentType: "application/json",
                dataType: "json",
                success: function (msg) {
                    alert("Your rationale has been saved.");
                    return;
                },
                error: function(e) {
                    alert(e);
                }
            });
        });
        <%--var url = '<%= Page.ResolveClientUrl("~/Default.aspx") %>';
        var rationale = $('#tbRationale');

        $('#btnAdd').click(function() {
            callWebServiceMethodJqueryObject(url, 'AddRationale', { rationale: rationale.val() }, onCallBack, null);
        });--%>

        //function onCallBack() {
        //    alert("Your rationale has been saved.");
        //    return;
        //}
    </script>
</asp:Content>
