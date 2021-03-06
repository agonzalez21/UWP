using System;
using wpfMill;

namespace lindexi.uwp.Framework.ViewModel
{
    internal class GetValueCombinationComposite<T> : CombinationComposite
    {
        public GetValueCombinationComposite(ViewModelBase source, Action<T> continueWith) : base(source)
        {
            ContinueWith = continueWith;
        }

        private Action<T> ContinueWith { get; set; }

        public override void Run(IViewModel source, IMessage message)
        {
            var viewmodel = source as IViewModelValue<T>;
            if (viewmodel != null)
            {
                ContinueWith(viewmodel.Value);
            }
        }
    }
}