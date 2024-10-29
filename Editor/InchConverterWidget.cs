using System.Text.RegularExpressions;
using Editor;

namespace Sonic853.InchConverterLib.Editor
{
    [Dock( "Editor", "Inch Converter" )]
    public class InchConverterWidget : Widget
    {
        protected static InchConverterWidget instance;
        public static InchConverterWidget Instance => instance ?? new( null );
        LineEdit inputm;
        LineEdit inputcm;
        LineEdit inputin;
        public InchConverterWidget( Widget parent ) : base( parent, false )
        {
            // Create a Column Layout
            Layout = Layout.Column();
            // Give it some Margins/Spacing
            Layout.Margin = 4;
            Layout.Spacing = 4;
            // Apply some CSS styling
            SetStyles( "background-color: #303445; color: white; font-weight: 600;" );

            // Add some child Widgets to the Layout
            Layout.Add( new Label( "m:", this ) );
            inputm = Layout.Add( new LineEdit()
            {
                Text = "0.0254",
            } );
            Layout.Add( new Label( "cm:", this ) );
            inputcm = Layout.Add( new LineEdit()
            {
                Text = "2.54",
            } );
            Layout.Add( new Label( "inch:", this ) );
            inputin = Layout.Add( new LineEdit()
            {
                Text = "1",
            } );
            inputm.TextChanged += InputMTextChanged;
            inputcm.TextChanged += InputCMTextChanged;
            inputin.TextChanged += InputINTextChanged;
        }
        void InputMTextChanged( string text )
        {
            var _text = NumberOnly( text );

            if ( !float.TryParse( _text, out var m ) ) { return; }
            if ( m == 0f )
            {
                ToZero();
                return;
            }
            inputcm.TextChanged -= InputCMTextChanged;
            inputcm.Text = $"{InchConverter.MToCm(m)}";
            inputcm.TextChanged += InputCMTextChanged;

            inputin.TextChanged -= InputINTextChanged;
            inputin.Text = $"{InchConverter.MToIn(m)}";
            inputin.TextChanged += InputINTextChanged;

            inputm.TextChanged -= InputMTextChanged;
            inputm.Text = _text;
            inputm.TextChanged += InputMTextChanged;
        }
        void InputCMTextChanged( string text )
        {
            var _text = NumberOnly( text );

            if ( !float.TryParse( _text, out var cm ) ) { return; }
            if ( cm == 0f )
            {
                ToZero();
                return;
            }
            inputm.TextChanged -= InputMTextChanged;
            inputm.Text = $"{InchConverter.CmToM(cm)}";
            inputm.TextChanged += InputMTextChanged;

            inputin.TextChanged -= InputINTextChanged;
            inputin.Text = $"{InchConverter.CmToIn(cm)}";
            inputin.TextChanged += InputINTextChanged;

            inputcm.TextChanged -= InputCMTextChanged;
            inputcm.Text = _text;
            inputcm.TextChanged += InputCMTextChanged;
        }
        void InputINTextChanged( string text )
        {
            var _text = NumberOnly( text );

            if ( !float.TryParse( _text, out var inch ) ) { return; }
            if ( inch == 0f )
            {
                ToZero();
                return;
            }
            inputcm.TextChanged -= InputCMTextChanged;
            inputcm.Text = $"{InchConverter.InToCm(inch)}";
            inputcm.TextChanged += InputCMTextChanged;

            inputm.TextChanged -= InputMTextChanged;
            inputm.Text = $"{InchConverter.InToM(inch)}";
            inputm.TextChanged += InputMTextChanged;

            inputin.TextChanged -= InputINTextChanged;
            inputin.Text = _text;
            inputin.TextChanged += InputINTextChanged;
        }
        void ToZero()
        {
            inputcm.TextChanged -= InputCMTextChanged;
            inputcm.Text = "0";
            inputcm.TextChanged += InputCMTextChanged;

            inputin.TextChanged -= InputINTextChanged;
            inputin.Text = "0";
            inputin.TextChanged += InputINTextChanged;

            inputm.TextChanged -= InputMTextChanged;
            inputm.Text = "0";
            inputm.TextChanged += InputMTextChanged;
        }
        string NumberOnly( string text )
        {
            var _text = Regex.Replace( text, @"[^0-9.]", "" );

            if ( string.IsNullOrEmpty( _text ) )
            {
                _text = "0";
            }
            return _text;
        }
        protected override bool OnClose()
        {
            base.OnClose();
            instance = null;
            return true;
        }
    }


}