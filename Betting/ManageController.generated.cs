// <auto-generated />
// This file was generated by a T4 template.
// Don't change it directly as your change would get overwritten.  Instead, make changes
// to the .tt file (i.e. the T4 template) and save it to regenerate this file.

// Make sure the compiler doesn't complain about missing Xml comments and CLS compliance
// 0108: suppress "Foo hides inherited member Foo. Use the new keyword if hiding was intended." when a controller and its abstract parent are both processed
// 0114: suppress "Foo.BarController.Baz()' hides inherited member 'Qux.BarController.Baz()'. To make the current member override that implementation, add the override keyword. Otherwise add the new keyword." when an action (with an argument) overrides an action in a parent controller
#pragma warning disable 1591, 3008, 3009, 0108, 0114
#region T4MVC

using System;
using System.Diagnostics;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Web;
using System.Web.Hosting;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;
using System.Web.Mvc.Html;
using System.Web.Routing;
using T4MVC;
namespace Betting.Controllers
{
    public partial class ManageController
    {
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected ManageController(Dummy d) { }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected RedirectToRouteResult RedirectToAction(ActionResult result)
        {
            var callInfo = result.GetT4MVCResult();
            return RedirectToRoute(callInfo.RouteValueDictionary);
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected RedirectToRouteResult RedirectToAction(Task<ActionResult> taskResult)
        {
            return RedirectToAction(taskResult.Result);
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected RedirectToRouteResult RedirectToActionPermanent(ActionResult result)
        {
            var callInfo = result.GetT4MVCResult();
            return RedirectToRoutePermanent(callInfo.RouteValueDictionary);
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected RedirectToRouteResult RedirectToActionPermanent(Task<ActionResult> taskResult)
        {
            return RedirectToActionPermanent(taskResult.Result);
        }

        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Threading.Tasks.Task<System.Web.Mvc.ActionResult> Index()
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Index);
            return System.Threading.Tasks.Task.FromResult(callInfo as System.Web.Mvc.ActionResult);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Threading.Tasks.Task<System.Web.Mvc.ActionResult> RemoveLogin()
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.RemoveLogin);
            return System.Threading.Tasks.Task.FromResult(callInfo as System.Web.Mvc.ActionResult);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Threading.Tasks.Task<System.Web.Mvc.ActionResult> VerifyPhoneNumber()
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.VerifyPhoneNumber);
            return System.Threading.Tasks.Task.FromResult(callInfo as System.Web.Mvc.ActionResult);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Threading.Tasks.Task<System.Web.Mvc.ActionResult> ManageLogins()
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.ManageLogins);
            return System.Threading.Tasks.Task.FromResult(callInfo as System.Web.Mvc.ActionResult);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Web.Mvc.ActionResult LinkLogin()
        {
            return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.LinkLogin);
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ManageController Actions { get { return MVC.Manage; } }
        [GeneratedCode("T4MVC", "2.0")]
        public readonly string Area = "";
        [GeneratedCode("T4MVC", "2.0")]
        public readonly string Name = "Manage";
        [GeneratedCode("T4MVC", "2.0")]
        public const string NameConst = "Manage";
        [GeneratedCode("T4MVC", "2.0")]
        static readonly ActionNamesClass s_actions = new ActionNamesClass();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionNamesClass ActionNames { get { return s_actions; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionNamesClass
        {
            public readonly string Index = "Index";
            public readonly string RemoveLogin = "RemoveLogin";
            public readonly string AddPhoneNumber = "AddPhoneNumber";
            public readonly string EnableTwoFactorAuthentication = "EnableTwoFactorAuthentication";
            public readonly string DisableTwoFactorAuthentication = "DisableTwoFactorAuthentication";
            public readonly string VerifyPhoneNumber = "VerifyPhoneNumber";
            public readonly string RemovePhoneNumber = "RemovePhoneNumber";
            public readonly string ChangePassword = "ChangePassword";
            public readonly string SetPassword = "SetPassword";
            public readonly string ManageLogins = "ManageLogins";
            public readonly string LinkLogin = "LinkLogin";
            public readonly string LinkLoginCallback = "LinkLoginCallback";
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionNameConstants
        {
            public const string Index = "Index";
            public const string RemoveLogin = "RemoveLogin";
            public const string AddPhoneNumber = "AddPhoneNumber";
            public const string EnableTwoFactorAuthentication = "EnableTwoFactorAuthentication";
            public const string DisableTwoFactorAuthentication = "DisableTwoFactorAuthentication";
            public const string VerifyPhoneNumber = "VerifyPhoneNumber";
            public const string RemovePhoneNumber = "RemovePhoneNumber";
            public const string ChangePassword = "ChangePassword";
            public const string SetPassword = "SetPassword";
            public const string ManageLogins = "ManageLogins";
            public const string LinkLogin = "LinkLogin";
            public const string LinkLoginCallback = "LinkLoginCallback";
        }


        static readonly ActionParamsClass_Index s_params_Index = new ActionParamsClass_Index();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_Index IndexParams { get { return s_params_Index; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_Index
        {
            public readonly string message = "message";
        }
        static readonly ActionParamsClass_RemoveLogin s_params_RemoveLogin = new ActionParamsClass_RemoveLogin();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_RemoveLogin RemoveLoginParams { get { return s_params_RemoveLogin; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_RemoveLogin
        {
            public readonly string loginProvider = "loginProvider";
            public readonly string providerKey = "providerKey";
        }
        static readonly ActionParamsClass_AddPhoneNumber s_params_AddPhoneNumber = new ActionParamsClass_AddPhoneNumber();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_AddPhoneNumber AddPhoneNumberParams { get { return s_params_AddPhoneNumber; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_AddPhoneNumber
        {
            public readonly string model = "model";
        }
        static readonly ActionParamsClass_VerifyPhoneNumber s_params_VerifyPhoneNumber = new ActionParamsClass_VerifyPhoneNumber();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_VerifyPhoneNumber VerifyPhoneNumberParams { get { return s_params_VerifyPhoneNumber; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_VerifyPhoneNumber
        {
            public readonly string phoneNumber = "phoneNumber";
            public readonly string model = "model";
        }
        static readonly ActionParamsClass_ChangePassword s_params_ChangePassword = new ActionParamsClass_ChangePassword();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_ChangePassword ChangePasswordParams { get { return s_params_ChangePassword; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_ChangePassword
        {
            public readonly string model = "model";
        }
        static readonly ActionParamsClass_SetPassword s_params_SetPassword = new ActionParamsClass_SetPassword();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_SetPassword SetPasswordParams { get { return s_params_SetPassword; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_SetPassword
        {
            public readonly string model = "model";
        }
        static readonly ActionParamsClass_ManageLogins s_params_ManageLogins = new ActionParamsClass_ManageLogins();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_ManageLogins ManageLoginsParams { get { return s_params_ManageLogins; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_ManageLogins
        {
            public readonly string message = "message";
        }
        static readonly ActionParamsClass_LinkLogin s_params_LinkLogin = new ActionParamsClass_LinkLogin();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_LinkLogin LinkLoginParams { get { return s_params_LinkLogin; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_LinkLogin
        {
            public readonly string provider = "provider";
        }
        static readonly ViewsClass s_views = new ViewsClass();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ViewsClass Views { get { return s_views; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ViewsClass
        {
            static readonly _ViewNamesClass s_ViewNames = new _ViewNamesClass();
            public _ViewNamesClass ViewNames { get { return s_ViewNames; } }
            public class _ViewNamesClass
            {
                public readonly string AddPhoneNumber = "AddPhoneNumber";
                public readonly string ChangePassword = "ChangePassword";
                public readonly string Index = "Index";
                public readonly string ManageLogins = "ManageLogins";
                public readonly string SetPassword = "SetPassword";
                public readonly string VerifyPhoneNumber = "VerifyPhoneNumber";
            }
            public readonly string AddPhoneNumber = "~/Views/Manage/AddPhoneNumber.cshtml";
            public readonly string ChangePassword = "~/Views/Manage/ChangePassword.cshtml";
            public readonly string Index = "~/Views/Manage/Index.cshtml";
            public readonly string ManageLogins = "~/Views/Manage/ManageLogins.cshtml";
            public readonly string SetPassword = "~/Views/Manage/SetPassword.cshtml";
            public readonly string VerifyPhoneNumber = "~/Views/Manage/VerifyPhoneNumber.cshtml";
        }
    }

    [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
    public partial class T4MVC_ManageController : Betting.Controllers.ManageController
    {
        public T4MVC_ManageController() : base(Dummy.Instance) { }

        [NonAction]
        partial void IndexOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, Betting.Controllers.ManageController.ManageMessageId? message);

        [NonAction]
        public override System.Threading.Tasks.Task<System.Web.Mvc.ActionResult> Index(Betting.Controllers.ManageController.ManageMessageId? message)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Index);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "message", message);
            IndexOverride(callInfo, message);
            return System.Threading.Tasks.Task.FromResult(callInfo as System.Web.Mvc.ActionResult);
        }

        [NonAction]
        partial void RemoveLoginOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, string loginProvider, string providerKey);

        [NonAction]
        public override System.Threading.Tasks.Task<System.Web.Mvc.ActionResult> RemoveLogin(string loginProvider, string providerKey)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.RemoveLogin);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "loginProvider", loginProvider);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "providerKey", providerKey);
            RemoveLoginOverride(callInfo, loginProvider, providerKey);
            return System.Threading.Tasks.Task.FromResult(callInfo as System.Web.Mvc.ActionResult);
        }

        [NonAction]
        partial void AddPhoneNumberOverride(T4MVC_System_Web_Mvc_ActionResult callInfo);

        [NonAction]
        public override System.Web.Mvc.ActionResult AddPhoneNumber()
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.AddPhoneNumber);
            AddPhoneNumberOverride(callInfo);
            return callInfo;
        }

        [NonAction]
        partial void AddPhoneNumberOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, Betting.Models.AddPhoneNumberViewModel model);

        [NonAction]
        public override System.Threading.Tasks.Task<System.Web.Mvc.ActionResult> AddPhoneNumber(Betting.Models.AddPhoneNumberViewModel model)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.AddPhoneNumber);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "model", model);
            AddPhoneNumberOverride(callInfo, model);
            return System.Threading.Tasks.Task.FromResult(callInfo as System.Web.Mvc.ActionResult);
        }

        [NonAction]
        partial void EnableTwoFactorAuthenticationOverride(T4MVC_System_Web_Mvc_ActionResult callInfo);

        [NonAction]
        public override System.Threading.Tasks.Task<System.Web.Mvc.ActionResult> EnableTwoFactorAuthentication()
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.EnableTwoFactorAuthentication);
            EnableTwoFactorAuthenticationOverride(callInfo);
            return System.Threading.Tasks.Task.FromResult(callInfo as System.Web.Mvc.ActionResult);
        }

        [NonAction]
        partial void DisableTwoFactorAuthenticationOverride(T4MVC_System_Web_Mvc_ActionResult callInfo);

        [NonAction]
        public override System.Threading.Tasks.Task<System.Web.Mvc.ActionResult> DisableTwoFactorAuthentication()
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.DisableTwoFactorAuthentication);
            DisableTwoFactorAuthenticationOverride(callInfo);
            return System.Threading.Tasks.Task.FromResult(callInfo as System.Web.Mvc.ActionResult);
        }

        [NonAction]
        partial void VerifyPhoneNumberOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, string phoneNumber);

        [NonAction]
        public override System.Threading.Tasks.Task<System.Web.Mvc.ActionResult> VerifyPhoneNumber(string phoneNumber)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.VerifyPhoneNumber);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "phoneNumber", phoneNumber);
            VerifyPhoneNumberOverride(callInfo, phoneNumber);
            return System.Threading.Tasks.Task.FromResult(callInfo as System.Web.Mvc.ActionResult);
        }

        [NonAction]
        partial void VerifyPhoneNumberOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, Betting.Models.VerifyPhoneNumberViewModel model);

        [NonAction]
        public override System.Threading.Tasks.Task<System.Web.Mvc.ActionResult> VerifyPhoneNumber(Betting.Models.VerifyPhoneNumberViewModel model)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.VerifyPhoneNumber);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "model", model);
            VerifyPhoneNumberOverride(callInfo, model);
            return System.Threading.Tasks.Task.FromResult(callInfo as System.Web.Mvc.ActionResult);
        }

        [NonAction]
        partial void RemovePhoneNumberOverride(T4MVC_System_Web_Mvc_ActionResult callInfo);

        [NonAction]
        public override System.Threading.Tasks.Task<System.Web.Mvc.ActionResult> RemovePhoneNumber()
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.RemovePhoneNumber);
            RemovePhoneNumberOverride(callInfo);
            return System.Threading.Tasks.Task.FromResult(callInfo as System.Web.Mvc.ActionResult);
        }

        [NonAction]
        partial void ChangePasswordOverride(T4MVC_System_Web_Mvc_ActionResult callInfo);

        [NonAction]
        public override System.Web.Mvc.ActionResult ChangePassword()
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.ChangePassword);
            ChangePasswordOverride(callInfo);
            return callInfo;
        }

        [NonAction]
        partial void ChangePasswordOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, Betting.Models.ChangePasswordViewModel model);

        [NonAction]
        public override System.Threading.Tasks.Task<System.Web.Mvc.ActionResult> ChangePassword(Betting.Models.ChangePasswordViewModel model)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.ChangePassword);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "model", model);
            ChangePasswordOverride(callInfo, model);
            return System.Threading.Tasks.Task.FromResult(callInfo as System.Web.Mvc.ActionResult);
        }

        [NonAction]
        partial void SetPasswordOverride(T4MVC_System_Web_Mvc_ActionResult callInfo);

        [NonAction]
        public override System.Web.Mvc.ActionResult SetPassword()
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.SetPassword);
            SetPasswordOverride(callInfo);
            return callInfo;
        }

        [NonAction]
        partial void SetPasswordOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, Betting.Models.SetPasswordViewModel model);

        [NonAction]
        public override System.Threading.Tasks.Task<System.Web.Mvc.ActionResult> SetPassword(Betting.Models.SetPasswordViewModel model)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.SetPassword);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "model", model);
            SetPasswordOverride(callInfo, model);
            return System.Threading.Tasks.Task.FromResult(callInfo as System.Web.Mvc.ActionResult);
        }

        [NonAction]
        partial void ManageLoginsOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, Betting.Controllers.ManageController.ManageMessageId? message);

        [NonAction]
        public override System.Threading.Tasks.Task<System.Web.Mvc.ActionResult> ManageLogins(Betting.Controllers.ManageController.ManageMessageId? message)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.ManageLogins);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "message", message);
            ManageLoginsOverride(callInfo, message);
            return System.Threading.Tasks.Task.FromResult(callInfo as System.Web.Mvc.ActionResult);
        }

        [NonAction]
        partial void LinkLoginOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, string provider);

        [NonAction]
        public override System.Web.Mvc.ActionResult LinkLogin(string provider)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.LinkLogin);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "provider", provider);
            LinkLoginOverride(callInfo, provider);
            return callInfo;
        }

        [NonAction]
        partial void LinkLoginCallbackOverride(T4MVC_System_Web_Mvc_ActionResult callInfo);

        [NonAction]
        public override System.Threading.Tasks.Task<System.Web.Mvc.ActionResult> LinkLoginCallback()
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.LinkLoginCallback);
            LinkLoginCallbackOverride(callInfo);
            return System.Threading.Tasks.Task.FromResult(callInfo as System.Web.Mvc.ActionResult);
        }

    }
}

#endregion T4MVC
#pragma warning restore 1591, 3008, 3009, 0108, 0114
