<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EventSave.aspx.cs" Inherits="WebClient.EventSave" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style12 {
            width: 457px;
            height: 23px;
        }
        .auto-style13 {
            height: 23px;
            width: 384px;
        }
        .auto-style21 {
            width: 54%;
            height: 339px;
            margin-right: 0px;
        }
        .auto-style24 {
            width: 457px;
        }
        .auto-style25 {
            width: 457px;
            height: 26px;
        }
        .auto-style26 {
            height: 26px;
            width: 384px;
        }
        .auto-style29 {
            width: 457px;
            height: 25px;
        }
        .auto-style30 {
            height: 25px;
            width: 384px;
        }
        .auto-style31 {
            margin-top: 134px;
        }
    </style>
</head>
<body>
   <h1 style="margin-left:100px;margin-top:50px">EVENT MANAGEMENT</h1>
    <form id="form1" runat="server">
        <div class="auto-style31">
            <table border="1" class="auto-style21" style="margin: 100px">
                
                <tr>
                    <td class="auto-style29" style="font-style: normal; font-weight: bolder">Event Name</td>
                    <td class="auto-style30">
                        <asp:TextBox ID="Name" runat="server" Width="150px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style29" style="font-style: normal; font-weight: bolder">Event&nbsp; Strength</td>
                    <td class="auto-style30">
                        <asp:TextBox ID="Strength" runat="server" Width="150px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style29" style="font-style: normal; font-weight: bolder">Event Organizer By</td>
                    <td class="auto-style30">
                        <asp:TextBox ID="organizer" runat="server" Width="150px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style29" style="font-style: normal; font-weight: bolder">Event Date</td>
                    <td class="auto-style30">
                        <asp:TextBox ID="Event_date" runat="server" Width="150px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style29" style="font-style: normal; font-weight: bolder">Discription</td>
                    <td class="auto-style30">
                        <asp:TextBox ID="dis" runat="server" Height="31px" Width="150px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style25" style="font-style: normal; font-weight: bolder">Duraction in Number&nbsp; of hour</td>
                    <td class="auto-style26" style="font-style: normal; font-weight: bolder">
                        <asp:TextBox ID="Duraction" runat="server" Width="150px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style29" style="font-style: normal; font-weight: bolder">Event Registration Start From</td>
                    <td class="auto-style30">
                        <asp:TextBox ID="Registration_date" runat="server" Width="150px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style29" style="font-style: normal; font-weight: bolder">ContactNo</td>
                    <td class="auto-style30">
                        <asp:TextBox ID="ContactNo" runat="server" Width="150px"></asp:TextBox>
                       
                    </td>
                </tr>
                <tr>
                    <td class="auto-style29" style="font-style: normal; font-weight: bolder">
                        <asp:CheckBox ID="is_group" runat="server" />
                        Is group Event</td>
                    <td class="auto-style30">
                        <asp:Button ID="Button5" runat="server" OnClick="Button5_Click" Text="Clear Data" Width="95px" />
                    </td>
                </tr>

                <tr>
                    <td class="auto-style25">
                        Id :&nbsp;&nbsp;
                        <asp:TextBox ID="ID" runat="server"></asp:TextBox>
                    </td>
                    <td class="auto-style26" style="color: #FF0000; font-style: normal; text-decoration: blink; text-transform: none; font-family: Bahnschrift; font-variant: small-caps">
                        *for Get,Update &amp; Delete Event&nbsp; Id&nbsp;is&nbsp;required</td>
                </tr>
                <tr>
                    <td class="auto-style12">
                        <asp:Button ID="Button1" runat="server" BorderStyle="Solid" Text="Save Event" OnClick="Button1_Click" BorderColor="#66FF33" Width="95px"/>
                    </td>
                    <td class="auto-style13">
                        <asp:Button ID="Button2" runat="server" BorderColor="Yellow" BorderStyle="Solid" OnClick="Button2_Click" Text="Get Event" Width="95px" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style25">
                        <asp:Button ID="Button3" runat="server" BorderColor="#FF3300" BorderStyle="Solid" Text="Delet Event" Width="95px" OnClick="Button3_Click" style="height: 26px" />
                    </td>
                    <td class="auto-style26" style="color: #FF0000; font-style: normal; font-variant: small-caps; text-decoration: blink">
                        <asp:Button ID="Button4" runat="server" BorderColor="Blue" OnClick="Button4_Click" Text="Update" Width="95px" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style24" style="font-style: normal; font-weight: bolder">

                        <asp:Label ID="Label1" runat="server" Text="Label" ForeColor="#33CC33"></asp:Label>

                    </td>
                    <td>

                    </td>
                </tr>
            </table>
        </div>
    </form>
    <p>
&nbsp;&nbsp;
    </p>
</body>
</html>
