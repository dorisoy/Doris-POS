// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Dreamer.Pages.SettingPage.BrandPage___Copy
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\CodecanonProject\Dotnet5\InventoryPos\Dreamer\Dreamer\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\CodecanonProject\Dotnet5\InventoryPos\Dreamer\Dreamer\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\CodecanonProject\Dotnet5\InventoryPos\Dreamer\Dreamer\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\CodecanonProject\Dotnet5\InventoryPos\Dreamer\Dreamer\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\CodecanonProject\Dotnet5\InventoryPos\Dreamer\Dreamer\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\CodecanonProject\Dotnet5\InventoryPos\Dreamer\Dreamer\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\CodecanonProject\Dotnet5\InventoryPos\Dreamer\Dreamer\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\CodecanonProject\Dotnet5\InventoryPos\Dreamer\Dreamer\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\CodecanonProject\Dotnet5\InventoryPos\Dreamer\Dreamer\_Imports.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\CodecanonProject\Dotnet5\InventoryPos\Dreamer\Dreamer\_Imports.razor"
using Dreamer;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\CodecanonProject\Dotnet5\InventoryPos\Dreamer\Dreamer\_Imports.razor"
using Dreamer.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\CodecanonProject\Dotnet5\InventoryPos\Dreamer\Dreamer\_Imports.razor"
using Dreamer.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\CodecanonProject\Dotnet5\InventoryPos\Dreamer\Dreamer\_Imports.razor"
using Dreamer.Services.Interface;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "D:\CodecanonProject\Dotnet5\InventoryPos\Dreamer\Dreamer\_Imports.razor"
using Dreamer.Services.Repository;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "D:\CodecanonProject\Dotnet5\InventoryPos\Dreamer\Dreamer\_Imports.razor"
using Dreamer.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "D:\CodecanonProject\Dotnet5\InventoryPos\Dreamer\Dreamer\_Imports.razor"
using Dreamer.Data.Connection;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "D:\CodecanonProject\Dotnet5\InventoryPos\Dreamer\Dreamer\_Imports.razor"
using Dreamer.Data.Apimodel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "D:\CodecanonProject\Dotnet5\InventoryPos\Dreamer\Dreamer\_Imports.razor"
using Dreamer.Data.Inventory;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "D:\CodecanonProject\Dotnet5\InventoryPos\Dreamer\Dreamer\_Imports.razor"
using Dreamer.Data.Setting;

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "D:\CodecanonProject\Dotnet5\InventoryPos\Dreamer\Dreamer\_Imports.razor"
using Blazored.LocalStorage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "D:\CodecanonProject\Dotnet5\InventoryPos\Dreamer\Dreamer\_Imports.razor"
using Microsoft.Extensions.Configuration;

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "D:\CodecanonProject\Dotnet5\InventoryPos\Dreamer\Dreamer\_Imports.razor"
using Microsoft.Extensions.Localization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "D:\CodecanonProject\Dotnet5\InventoryPos\Dreamer\Dreamer\_Imports.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "D:\CodecanonProject\Dotnet5\InventoryPos\Dreamer\Dreamer\_Imports.razor"
using MudBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\CodecanonProject\Dotnet5\InventoryPos\Dreamer\Dreamer\Pages\SettingPage\BrandPage - Copy\Brandlist.razor"
using Dreamer.Services.IService;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/setting/brandlist")]
    public partial class Brandlist : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 183 "D:\CodecanonProject\Dotnet5\InventoryPos\Dreamer\Dreamer\Pages\SettingPage\BrandPage - Copy\Brandlist.razor"
       
    private bool dense = true;
    private bool hover = true;
    private bool striped = true;
    private bool bordered = true;
    private string searchString1 = "";
    private string searchString2 = "";
    Brand master = new Brand();
    List<Brand> listModel;
    bool isShow = false;
    string Title;
    private List<string> DeletedImageNames { get; set; } = new List<string>();
    private bool IsImageUploadProcessStarted { get; set; } = false;
    protected override void OnInitialized()
    {
        LoadData();
    }
    private async void LoadData()
    {
        isShow = false;
        listModel = _brand.GetAll();
        StateHasChanged();
    }
    private async void Save()
    {
        if (master.BrandId == 0)
        {
            if (master.Name == string.Empty)
            {
                Snackbar.Add("Type Brand.", Severity.Info);
            }
            else
            {
                var isCheck = _brand.CheckName(master.Name);
                if (isCheck == true)
                {
                    Snackbar.Add("Already Exists.", Severity.Success);
                }
                else
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 223 "D:\CodecanonProject\Dotnet5\InventoryPos\Dreamer\Dreamer\Pages\SettingPage\BrandPage - Copy\Brandlist.razor"
                     if (master.ImageUrls.Count > 0)
                    {
                        foreach (var imageUrl in master.ImageUrls)
                        {
                            master.Image = imageUrl;
                        }
                    }
                    else
                    {
                        master.Image = string.Empty;
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 233 "D:\CodecanonProject\Dotnet5\InventoryPos\Dreamer\Dreamer\Pages\SettingPage\BrandPage - Copy\Brandlist.razor"
                     
                    master.CompanyId = 1;
                    master.AddedDate = DateTime.UtcNow;
                    _brand.Save(master);
                    LoadData();
                    Snackbar.Add("Saved Successfully.", Severity.Success);
                }
            }
        }
        else
        {
            if (master.Name == string.Empty)
            {
                Snackbar.Add("Type Brand.", Severity.Info);
            }
            else
            {
                var isCheck = _brand.CheckNameId(master.Name);
                if (isCheck == master.BrandId || isCheck == 0)
                {
                    master.CompanyId = 1;
                    master.ModifyDate = DateTime.UtcNow;
                    _brand.Update(master);
                    LoadData();
                    Snackbar.Add("Saved Successfully.", Severity.Success);
                }
                else
                {
                    Snackbar.Add("Already Exists.", Severity.Info);
                }
            }
        }
    }
    async Task EditModel(int id)
    {
        isShow = true;
        Title = "Edit Brand";
        master = _brand.Edit(id);
    }
    async Task Delete(int id)
    {
        bool confirmed = await JsRuntime.InvokeAsync<bool>("confirm", "Are you sure?");
        if (confirmed)
        {
            if (id != 1)
            {
                bool isSave = false;
                isSave = _brand.Delete(id);
                if (isSave == true)
                {
                    Snackbar.Add("Delete Successfully.", Severity.Success);
                    LoadData();
                }
                else
                {
                    Snackbar.Add("Cannot be delete. already in used.", Severity.Info);
                }
            }
            else
            {
                Snackbar.Add("Default data cannot be delete.", Severity.Info);
            }
        }
    }
    internal async Task DeletePhoto(string imageUrl)
    {
        try
        {
            var imageIndex = master.ImageUrls.FindIndex(x => x == imageUrl);
            var imageName = imageUrl.Replace($"{navManager.BaseUri}RoomImages/", "");
            if (master.BrandId == 0)
            {
                var result = FileUpload.DeleteFile(imageName);
            }
            else
            {
                //update
                DeletedImageNames ??= new List<string>();
                DeletedImageNames.Add(imageUrl);
            }
            master.ImageUrls.RemoveAt(imageIndex);
        }
        catch (Exception ex)
        {
            Snackbar.Add(ex.Message, Severity.Info);
        }

    }
    private void ShowModel()
    {
        isShow = true;
        Title = "Add Brand";
        master.BrandId = 0;
        master.Name = string.Empty;
        StateHasChanged();
    }
    private void CloseModel()
    {
        isShow = false;
        StateHasChanged();
    }
    private bool Search(Brand element)
    {
        if (string.IsNullOrWhiteSpace(searchString1))
            return true;
        if (element.Name.Contains(searchString1, StringComparison.OrdinalIgnoreCase))
            return true;
        return false;
    }
        private async Task HandleImageUpload(InputFileChangeEventArgs e)
    {
        IsImageUploadProcessStarted = true;
        try
        {
            var images = new List<string>();
            if (e.GetMultipleFiles().Count > 0)
            {
                foreach (var file in e.GetMultipleFiles())
                {
                    System.IO.FileInfo fileInfo = new System.IO.FileInfo(file.Name);
                    if (fileInfo.Extension.ToLower() == ".jpg" ||
                        fileInfo.Extension.ToLower() == ".png" ||
                        fileInfo.Extension.ToLower() == ".jpeg")
                    {
                        var uploadedImagePath = await FileUpload.UploadFile(file);
                        images.Add(uploadedImagePath);
                    }
                    else
                    {
                        Snackbar.Add("Please select .jpg/.jpeg/.png file only", Severity.Info);
                        return;
                    }
                }

                if (images.Any())
                {
                    if (master.ImageUrls != null && master.ImageUrls.Any())
                    {
                        master.ImageUrls.AddRange(images);
                    }
                    else
                    {
                        master.ImageUrls = new List<string>();
                        master.ImageUrls.AddRange(images);
                    }
                }
                else
                {
                    Snackbar.Add("Image uploading failed", Severity.Info);
                    return;
                }
            }
            IsImageUploadProcessStarted = false;
        }
        catch (Exception ex)
        {
            Snackbar.Add(ex.Message, Severity.Info);
        }



    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IFileUpload FileUpload { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ISnackbar Snackbar { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JsRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IBrand _brand { get; set; }
    }
}
#pragma warning restore 1591
