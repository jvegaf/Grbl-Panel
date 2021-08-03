using System;
using System.ComponentModel;
using System.Diagnostics;

namespace GrblPanel.My
{
    internal static partial class MyProject
    {
        internal partial class MyForms
        {
            [EditorBrowsable(EditorBrowsableState.Never)]
            public AboutBox m_AboutBox;

            public AboutBox AboutBox
            {
                [DebuggerHidden]
                get
                {
                    m_AboutBox = Create__Instance__(m_AboutBox);
                    return m_AboutBox;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_AboutBox))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_AboutBox);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public GrblGui m_GrblGui;

            public GrblGui GrblGui
            {
                [DebuggerHidden]
                get
                {
                    m_GrblGui = Create__Instance__(m_GrblGui);
                    return m_GrblGui;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_GrblGui))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_GrblGui);
                }
            }
        }
    }
}