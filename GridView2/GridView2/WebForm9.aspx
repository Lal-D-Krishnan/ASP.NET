<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm9.aspx.cs" Inherits="GridView2.WebForm9" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <table class="auto-style1">
            <tr>
                <td>
                    <asp:Label ID="Label1" runat="server" Text="Name"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label2" runat="server" Text="Image"></asp:Label>
                </td>
                <td>
                    <asp:Image ID="Image1" runat="server" Height="156px" Width="186px" />
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label3" runat="server" Text="Edit Image"></asp:Label>
                </td>
                <td>
                    
        <asp:FileUpload ID="FileUpload1" runat="server" onchange="handleFileUploadChange()" OnTextChanged="FileUpload1_TextChanged" />
       

                </td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Update" />
                </td>
                <td>&nbsp;</td>
            </tr>
        </table>
    </form>
  <script>
      function handleFileUploadChange() {
          console.log("111");
          // Get the reference to the FileUpload control
          var fileUploadControl = document.getElementById('FileUpload1');

        // Get the reference to the Image control
        var imageControl = document.getElementById("Image1");

          // Check if a file is selected
          if (fileUploadControl.files.length > 0) {
          console.log("222");
              // Get the selected file
              var selectedFile = fileUploadControl.files[0];

              // Create a FileReader to read the file
              var reader = new FileReader();

              // Set up an event handler for when the file is loaded
              reader.onload = function (event) {
                  // Get the data URL of the image
                  var imageUrl = event.target.result;
          console.log("333");

                  // Update the src attribute of the Image control to display the selected image
                  imageControl.src = imageUrl;
              };

          console.log("444");
              // Read the selected file as a data URL
              reader.readAsDataURL(selectedFile);
          }
      }
  </script>


</body>
</html>
