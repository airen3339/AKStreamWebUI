#pragma checksum "E:\源码\AKStreamWebUI\AKStreamWebUI\YiSha.Web\YiSha.Admin.Web\Areas\CameraManage\Views\CameraSessionManager\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ba1a024af1938d025dbaf20fd37c646fc2070f33"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_CameraManage_Views_CameraSessionManager_Index), @"mvc.1.0.view", @"/Areas/CameraManage/Views/CameraSessionManager/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
#nullable restore
#line 3 "E:\源码\AKStreamWebUI\AKStreamWebUI\YiSha.Web\YiSha.Admin.Web\Areas\CameraManage\_ViewImports.cshtml"
using Microsoft.AspNetCore.Mvc.ViewFeatures;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\源码\AKStreamWebUI\AKStreamWebUI\YiSha.Web\YiSha.Admin.Web\Areas\CameraManage\_ViewImports.cshtml"
using YiSha.Util;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "E:\源码\AKStreamWebUI\AKStreamWebUI\YiSha.Web\YiSha.Admin.Web\Areas\CameraManage\_ViewImports.cshtml"
using YiSha.Util.Extension;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "E:\源码\AKStreamWebUI\AKStreamWebUI\YiSha.Web\YiSha.Admin.Web\Areas\CameraManage\_ViewImports.cshtml"
using YiSha.Util.Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "E:\源码\AKStreamWebUI\AKStreamWebUI\YiSha.Web\YiSha.Admin.Web\Areas\CameraManage\_ViewImports.cshtml"
using YiSha.Enum;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "E:\源码\AKStreamWebUI\AKStreamWebUI\YiSha.Web\YiSha.Admin.Web\Areas\CameraManage\_ViewImports.cshtml"
using YiSha.Web.Code;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ba1a024af1938d025dbaf20fd37c646fc2070f33", @"/Areas/CameraManage/Views/CameraSessionManager/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e5b622e924f35698514110c8d85c04ddd5a27d39", @"/Areas/CameraManage/_ViewImports.cshtml")]
    public class Areas_CameraManage_Views_CameraSessionManager_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "E:\源码\AKStreamWebUI\AKStreamWebUI\YiSha.Web\YiSha.Admin.Web\Areas\CameraManage\Views\CameraSessionManager\Index.cshtml"
  
    Layout = "~/Views/Shared/_Index.cshtml";
 

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""container-div"">
    <div class=""row"">
        <div id=""searchDiv"" class=""col-sm-12 search-collapse"">
            <div class=""select-list"">
                <ul>

                </ul>
            </div>
        </div>
        <div class=""btn-group-sm hidden-xs"" id=""toolbar"">

        </div>
        <div class=""col-sm-12 select-table table-striped"">
            <table id=""gridTable"" data-mobile-responsive=""true""></table>
        </div>
    </div>
</div>

<script type=""text/javascript"">
    $(function () {
        $(""#mediaserverId"").ysComboBox({
            url: '");
#nullable restore
#line 25 "E:\源码\AKStreamWebUI\AKStreamWebUI\YiSha.Web\YiSha.Admin.Web\Areas\CameraManage\Views\CameraSessionManager\Index.cshtml"
             Write(Url.Content("~/CameraManage/CameraSessionManager/GetPushMediaList"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"',
            key: ""mediaServerId"",
            value: ""mediaServerId"",
            default: ""vm_linux""
        });
        initGrid();

    });

    function btn_playUrl(id) {
        //播放地址
    }

    function btn_playList(id) {
        //播放者客户端列表
    }

    function initGrid() {
        var queryUrl = '");
#nullable restore
#line 43 "E:\源码\AKStreamWebUI\AKStreamWebUI\YiSha.Web\YiSha.Admin.Web\Areas\CameraManage\Views\CameraSessionManager\Index.cshtml"
                   Write(Url.Content("~/CameraManage/CameraSessionManager/CameraSessionList"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"';
        $('#gridTable').ysTable({
            url: queryUrl,
            columns: [
                { checkbox: false, visible: false },
                { field: 'mainId', title: '设备ID' },
                { field: 'mediaServerId', title: '流媒体服务' },
                { field: 'channelId', title: 'Channel ID' },
                { field: 'deviceId', title: 'Device ID' },
                { field: 'channelName', title: '设备名称' },
                { field: 'ipV4Address', title: 'IpV4' },
                { field: 'ipV6Address', title: 'IpV6' },
                {
                    field: 'deviceNetworkType', title: '网络类型', formatter: function (value, row, index) {
                        return top.getDataDictKey('DeviceNetworkType', value);
                    }
                },
                {
                    field: 'deviceStreamType', title: '流类型', formatter: function (value, row, index) {
                        return top.getDataDictValue('DeviceStreamType', value);
                 ");
            WriteLiteral(@"   }
                },
                {
                    field: 'methodByGetStream', title: '拉流方式', formatter: function (value, row, index) {
                        return top.getDataDictValue('MethodByGetStream', value);
                    }
                },
                {
                    field: 'methodByGetStream', title: '拉流方式', formatter: function (value, row, index) {
                        return top.getDataDictValue('MethodByGetStream', value);
                    }
                },
                {
                    field: 'tlxy', title: '推流协议', formatter: function (value, row, index) {
                        if (!!row.mediaServerStreamInfo) {
                            return row.mediaServerStreamInfo.pushSocketType;
                        }
                    }
                },
                {
                    field: 'AutoVideo', title: '自动推拉流', formatter: function (value, row, index) {
                        if (value == true) {
              ");
            WriteLiteral(@"              return '<span class=""badge badge-primary"">' + ""启用"" + '</span>';
                        } else {
                            return '<span class=""badge badge-error"">' + ""禁用"" + '</span>';
                        }
                    }
                },
                {
                    field: 'AutoRecord', title: '自动录像', formatter: function (value, row, index) {
                        if (value == true) {
                            return '<span class=""badge badge-primary"">' + ""启用"" + '</span>';
                        } else {
                            return '<span class=""badge badge-error"">' + ""禁用"" + '</span>';
                        }
                    }
                },
                {
                    field: 'hasPtz', title: '云台控制', formatter: function (value, row, index) {
                        if (value == true) {
                            return '<span class=""badge badge-primary"">' + ""启用"" + '</span>';
                        } else {
           ");
            WriteLiteral(@"                 return '<span class=""badge badge-error"">' + ""禁用"" + '</span>';
                        }
                    }
                },
                {
                    field: 'rtpWithTcp', title: 'TCP推流', formatter: function (value, row, index) {
                        if (value == true) {
                            return '<span class=""badge badge-primary"">' + ""启用"" + '</span>';
                        } else {
                            return '<span class=""badge badge-error"">' + ""禁用"" + '</span>';
                        }
                    }
                },
                {
                    field: 'defaultRtpPort', title: '默认端口', formatter: function (value, row, index) {
                        if (value == true) {
                            return '<span class=""badge badge-primary"">' + ""启用"" + '</span>';
                        } else {
                            return '<span class=""badge badge-error"">' + ""禁用"" + '</span>';
                        }
        ");
            WriteLiteral(@"            }
                },
                {
                    field: 'cz', title: '操作', formatter: function (value, row, index) {
                        if (!!row.mediaServerStreamInfo) {
                            var actions = [];
                            actions.push('<div style=""display: flex;""><a class=""btn btn-info btn-xs""  href=""#"" onclick=""btn_playUrl(\'' + row.id + '\')"">播放地址</a><a class=""btn btn-info btn-xs"" style=""margin-left: 5px;"" href=""#"" onclick=""btn_playList(\'' + row.id + '\')"">在线客户端</a></div>');
                            return actions.join('');
                        }
                    }
                },
            ],
            queryParams: function (params) {
                var pagination = $('#gridTable').ysTable('getPagination', params);
                var queryString = $('#searchDiv').getWebControls(pagination);
                return queryString;
            }
        });
    }

    function searchGrid() {
        $('#gridTable').ysTable(");
            WriteLiteral("\'search\');\r\n        resetToolbarStatus();\r\n    }\r\n\r\n\r\n</script>\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
