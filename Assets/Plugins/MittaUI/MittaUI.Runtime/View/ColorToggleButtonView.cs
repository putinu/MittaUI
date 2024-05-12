using MittaUI.Runtime.Constant;
using MittaUI.Runtime.Parts;
using UnityEngine;
using uPalette.Runtime.Core;

namespace MittaUI.Runtime
{
    /// <summary>
    /// 色変化式トグルボタン
    /// </summary>
    [AddComponentMenu(AddComponentMenuConst.ButtonBath + nameof(ColorToggleButtonView))]
    public class ColorToggleButtonView : BaseToggleButton
    {
#if MITTAUI_USE_UPALETTE
        [SerializeField] private ColorEntryId _activeColorEntryId;
        [SerializeField] private ColorEntryId _inactiveColorEntryId;
        // TODO: 色を変化させる対象のGraphicを指定する
#endif
        
        protected override void OnDestroy()
        {
            base.OnDestroy();
            OnToggleChangedCallback = null;
        }

        protected override void Awake()
        {
            base.Awake();
            
        }
    }
}