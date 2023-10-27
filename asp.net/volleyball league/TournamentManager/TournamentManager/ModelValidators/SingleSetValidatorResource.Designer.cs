﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TournamentManager.ModelValidators {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class SingleSetValidatorResource {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal SingleSetValidatorResource() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("TournamentManager.ModelValidators.SingleSetValidatorResource", typeof(SingleSetValidatorResource).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Ball points must be zero or positive.
        /// </summary>
        internal static string BallPointsNotNegative {
            get {
                return ResourceManager.GetString("BallPointsNotNegative", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to At least one team must reach at least {0} ball points.
        /// </summary>
        internal static string NumOfPointsToWinReached {
            get {
                return ResourceManager.GetString("NumOfPointsToWinReached", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The maximum ball points can only be {0} with at least {1} point difference.
        /// </summary>
        internal static string RegularWinReachedWithOnePointAhead {
            get {
                return ResourceManager.GetString("RegularWinReachedWithOnePointAhead", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The difference in ball points must be {0} {1} if a team has {2} {3} ball points.
        /// </summary>
        internal static string RegularWinReachedWithTwoPlusPointsAhead {
            get {
                return ResourceManager.GetString("RegularWinReachedWithTwoPlusPointsAhead", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to at least.
        /// </summary>
        internal static string TextAtLeast {
            get {
                return ResourceManager.GetString("TextAtLeast", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to exactly.
        /// </summary>
        internal static string TextExactly {
            get {
                return ResourceManager.GetString("TextExactly", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to more than.
        /// </summary>
        internal static string TextMoreThan {
            get {
                return ResourceManager.GetString("TextMoreThan", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The maximum ball points must be {0} with at least {1} point difference.
        /// </summary>
        internal static string TieBreakWinReachedWithOnePointAhead {
            get {
                return ResourceManager.GetString("TieBreakWinReachedWithOnePointAhead", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The difference in ball points must be {0} {1} if a team has {2} {3} ball points.
        /// </summary>
        internal static string TieBreakWinReachedWithTwoPlusPointsAhead {
            get {
                return ResourceManager.GetString("TieBreakWinReachedWithTwoPlusPointsAhead", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The set cannot end in a tie.
        /// </summary>
        internal static string TieIsAllowed {
            get {
                return ResourceManager.GetString("TieIsAllowed", resourceCulture);
            }
        }
    }
}