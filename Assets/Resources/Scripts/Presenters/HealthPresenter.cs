using Resources.Scripts.Models;
using Resources.Scripts.Views;

namespace Resources.Scripts.Presenters
{
    public class HealthPresenter
    {
        private readonly HealthModel _model;
        private readonly HealthView _view;

        public HealthPresenter(HealthModel model, HealthView view)
        {
            _model = model;
            _view = view;
        }

        public void Update()
        {
            if (_view.Handler)
                _model.SetHealth(_view.Handler.HandleHealth);
            if (_model.HealthChangedFlag)
                _view.SetHealth(_model.Health);
        }

        public void LateUpdate()
        {
            _model.ResetFlag();
            _view.ResetHandler();
        }
    }
}