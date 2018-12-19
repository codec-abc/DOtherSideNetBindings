using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;

namespace DOtherSideDotNet
{
    public class NamedPtr
    {
        protected IntPtr _ptr;

        protected NamedPtr() { }

        public IntPtr Ptr => _ptr;

        public static implicit operator NamedPtr(IntPtr ptr)
        {
            var returned = new NamedPtr();
            returned._ptr = ptr;
            return returned;
        }

        //public static implicit operator IntPtr(NamedPtr ptr)
        //{
        //    return new IntPtr(ptr._ptr.ToInt64());
        //}
    }

    public class DosQMetaObject : NamedPtr
    {
        public static implicit operator DosQMetaObject(IntPtr ptr)
        {
            var returned = new DosQMetaObject();
            returned._ptr = ptr;
            return returned;
        }
    }

    public class DosQObject : NamedPtr
    {
        public static implicit operator DosQObject(IntPtr ptr)
        {
            var returned = new DosQObject();
            returned._ptr = ptr;
            return returned;
        }
    }

    public class DosQObjectWrapper : NamedPtr
    {
        public static implicit operator DosQObjectWrapper(IntPtr ptr)
        {
            var returned = new DosQObjectWrapper();
            returned._ptr = ptr;
            return returned;
        }
    }

    public class DosQVariant : NamedPtr
    {
        public static implicit operator DosQVariant(IntPtr ptr)
        {
            var returned = new DosQVariant();
            returned._ptr = ptr;
            return returned;
        }
    }

    public class DosQQmlContext : NamedPtr
    {
        public static implicit operator DosQQmlContext(IntPtr ptr)
        {
            var returned = new DosQQmlContext();
            returned._ptr = ptr;
            return returned;
        }
    }

    public class DosQQmlApplicationEngine : NamedPtr
    {
        public static implicit operator DosQQmlApplicationEngine(IntPtr ptr)
        {
            var returned = new DosQQmlApplicationEngine();
            returned._ptr = ptr;
            return returned;
        }
    }

    public unsafe static class DOtherSideBindings
    {
        public const string DllName = @"DOtherSide.dll";

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void dos_chararray_delete(sbyte* ptr);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        internal static extern sbyte* dos_qcoreapplication_application_dir_path();

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void dos_qapplication_create();

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void dos_qapplication_exec();

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void dos_qapplication_quit();

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void dos_qapplication_delete();

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void dos_qguiapplication_create();

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void dos_qguiapplication_exec();

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void dos_qguiapplication_quit();

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void dos_qguiapplication_delete();

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        private static extern void dos_qqmlcontext_setcontextproperty
        (
            IntPtr vptr, 
            [MarshalAs(UnmanagedType.LPStr)] string name, 
            IntPtr value
        );

       internal static void dos_qqmlcontext_setcontextproperty
       (
           DosQQmlContext vptr,
           string name,
           DosQVariant value
       )
       {
            dos_qqmlcontext_setcontextproperty
            (
                vptr.Ptr,
                name,
                value.Ptr
            );
       }

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "dos_qqmlapplicationengine_create")]
        private static extern IntPtr DosQqmlApplicationengineCreate();

        internal static DosQQmlApplicationEngine dos_qqmlapplicationengine_create()
        {
            IntPtr returnedPtr = DosQqmlApplicationengineCreate();
            DosQQmlApplicationEngine returned = returnedPtr;
            return returned;
        }
    }
}
