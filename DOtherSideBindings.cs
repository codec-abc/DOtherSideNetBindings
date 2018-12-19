using System;
using System.Runtime.InteropServices;
using System.Security;

namespace DOtherSideDotNet
{
    #region type
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

    public class DosQUrl : NamedPtr
    {
        public static implicit operator DosQUrl(IntPtr ptr)
        {
            var returned = new DosQUrl();
            returned._ptr = ptr;
            return returned;
        }
    }

    public class DosQQuickView : NamedPtr
    {
        public static implicit operator DosQQuickView(IntPtr ptr)
        {
            var returned = new DosQQuickView();
            returned._ptr = ptr;
            return returned;
        }
    }

    public class DosQHashIntByteArray : NamedPtr
    {
        public static implicit operator DosQHashIntByteArray(IntPtr ptr)
        {
            var returned = new DosQHashIntByteArray();
            returned._ptr = ptr;
            return returned;
        }
    }

    public class DosQModelIndex : NamedPtr
    {
        public static implicit operator DosQModelIndex(IntPtr ptr)
        {
            var returned = new DosQModelIndex();
            returned._ptr = ptr;
            return returned;
        }
    }

    public class DosQAbstractItemModel : NamedPtr
    {
        public static implicit operator DosQAbstractItemModel(IntPtr ptr)
        {
            var returned = new DosQAbstractItemModel();
            returned._ptr = ptr;
            return returned;
        }
    }

    public class DosQAbstractTableModel : NamedPtr
    {
        public static implicit operator DosQAbstractTableModel(IntPtr ptr)
        {
            var returned = new DosQAbstractTableModel();
            returned._ptr = ptr;
            return returned;
        }
    }

    public class DosQAbstractListModel : NamedPtr
    {
        public static implicit operator DosQAbstractListModel(IntPtr ptr)
        {
            var returned = new DosQAbstractListModel();
            returned._ptr = ptr;
            return returned;
        }
    }
    #endregion

    public unsafe static class DOtherSideBindings
    {
        public const string DllName = @"DOtherSide.dll";

        #region CharArray
        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void dos_chararray_delete(sbyte* ptr);
        #endregion

        #region QCoreApplication
        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        internal static extern sbyte* dos_qcoreapplication_application_dir_path();
        #endregion

        #region QApplication
        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void dos_qapplication_create();

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void dos_qapplication_exec();

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void dos_qapplication_quit();

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void dos_qapplication_delete();
        #endregion

        #region QGuiApplication
        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void dos_qguiapplication_create();

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void dos_qguiapplication_exec();

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void dos_qguiapplication_quit();

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        internal static extern void dos_qguiapplication_delete();
        #endregion

        #region QQmlContext
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
        #endregion

        #region QQmlApplicationEngine
        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "dos_qqmlapplicationengine_create")]
        private static extern IntPtr DosQqmlApplicationengineCreate();

        internal static DosQQmlApplicationEngine dos_qqmlapplicationengine_create()
        {
            return DosQqmlApplicationengineCreate();
        }

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "dos_qqmlapplicationengine_load")]
        private static extern void DosQqmlapplicationengineLoad(IntPtr vptr, [MarshalAs(UnmanagedType.LPStr)] string filename);

        internal static void dos_qqmlapplicationengine_load(DosQQmlApplicationEngine engine, [MarshalAs(UnmanagedType.LPStr)] string filename)
        {
            DosQqmlapplicationengineLoad(engine.Ptr, filename);
        }

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "dos_qqmlapplicationengine_load_url")]
        private static extern void DosQqmlapplicationengineLoadUrl(IntPtr vptr, IntPtr url);

        internal static void dos_qqmlapplicationengine_load_url(DosQQmlApplicationEngine engine, DosQUrl url)
        {
            DosQqmlapplicationengineLoadUrl(engine.Ptr, url.Ptr);
        }

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "dos_qqmlapplicationengine_load_data")]
        private static extern void DosQqmlapplicationengineLoadData(IntPtr vptr, [MarshalAs(UnmanagedType.LPStr)] string data);

        internal static void dos_qqmlapplicationengine_load_data(DosQQmlApplicationEngine engine, string data)
        {
            DosQqmlapplicationengineLoadData(engine.Ptr, data);
        }

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "dos_qqmlapplicationengine_add_import_path")]
        private static extern void DosQqmlapplicationengineAddImportPath(IntPtr vptr, [MarshalAs(UnmanagedType.LPStr)] string path);

        internal static void dos_qqmlapplicationengine_add_import_path(DosQQmlApplicationEngine engine, string path)
        {
            DosQqmlapplicationengineAddImportPath(engine.Ptr, path);
        }

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "dos_qqmlapplicationengine_context")]
        private static extern IntPtr DosQqmlapplicationengineContext(IntPtr vptr);

        internal static DosQQmlContext dos_qqmlapplicationengine_context(DosQQmlApplicationEngine engine)
        {
            return DosQqmlapplicationengineContext(engine.Ptr);
        }

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "dos_qqmlapplicationengine_delete")]
        private static extern void DosQqmlapplicationengineDelete(IntPtr vptr);

        internal static void dos_qqmlapplicationengine_delete(DosQQmlApplicationEngine engine)
        {
            DosQqmlapplicationengineDelete(engine.Ptr);
        }
        #endregion


    }
}
