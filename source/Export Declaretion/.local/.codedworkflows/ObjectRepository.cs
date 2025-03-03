using UiPath.CodedWorkflows.DescriptorIntegration;

namespace ExportDeclaretion.ObjectRepository
{
    public static class Descriptors
    {
        public static class ECUS5_VNACCS_2018__Electronic_Customs_Service__Version_6_0_151_Lastupdate_05062
        {
            static string _reference = "AXi_oqPm5k2ANIcpSjw3VQ/2s0Xwe9S9Um9ydya-fytxA";
            public static _Implementation._ECUS5_VNACCS_2018__Electronic_Customs_Service__Version_6_0_151_Lastupdate_05062.__ECUS5_VNACCS_2018__Electronic_Customs_Service ECUS5_VNACCS_2018__Electronic_Customs_Service { get; private set; } = new _Implementation._ECUS5_VNACCS_2018__Electronic_Customs_Service__Version_6_0_151_Lastupdate_05062.__ECUS5_VNACCS_2018__Electronic_Customs_Service();
        }
    }
}

namespace ExportDeclaretion._Implementation
{
    internal class ScreenDescriptorDefinition : IScreenDescriptorDefinition
    {
        public IScreenDescriptor Screen { get; set; }

        public string Reference { get; set; }

        public string DisplayName { get; set; }
    }

    internal class ElementDescriptorDefinition : IElementDescriptorDefinition
    {
        public IScreenDescriptor Screen { get; set; }

        public string Reference { get; set; }

        public string DisplayName { get; set; }

        public IElementDescriptor ParentElement { get; set; }

        public IElementDescriptor Element { get; set; }
    }

    namespace _ECUS5_VNACCS_2018__Electronic_Customs_Service__Version_6_0_151_Lastupdate_05062._ECUS5_VNACCS_2018__Electronic_Customs_Service
    {
        public class __Click___No_ : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Click___No_(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "AXi_oqPm5k2ANIcpSjw3VQ/qdgWD6yzsU6rliZ98_Bmzg", DisplayName = "Click '&No'", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _ECUS5_VNACCS_2018__Electronic_Customs_Service__Version_6_0_151_Lastupdate_05062
    {
        public class __ECUS5_VNACCS_2018__Electronic_Customs_Service : IScreenDescriptor
        {
            public IScreenDescriptorDefinition GetDefinition()
            {
                return _screenDescriptor;
            }

            private readonly ScreenDescriptorDefinition _screenDescriptor;
            public __ECUS5_VNACCS_2018__Electronic_Customs_Service()
            {
                _screenDescriptor = new ScreenDescriptorDefinition{Reference = "AXi_oqPm5k2ANIcpSjw3VQ/EIGDHND9cka43NqBUF_qcg", DisplayName = "ECUS5-VNACCS 2018 (Electronic Customs Service", Screen = this};
                Click___No_ = new _Implementation._ECUS5_VNACCS_2018__Electronic_Customs_Service__Version_6_0_151_Lastupdate_05062._ECUS5_VNACCS_2018__Electronic_Customs_Service.__Click___No_(this, null);
            }

            public _Implementation._ECUS5_VNACCS_2018__Electronic_Customs_Service__Version_6_0_151_Lastupdate_05062._ECUS5_VNACCS_2018__Electronic_Customs_Service.__Click___No_ Click___No_ { get; private set; }
        }
    }
}