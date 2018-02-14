using Android.Widget;
using GalaSoft.MvvmLight.Views;

namespace MvvmLightDemo
{
    public partial class MainActivity : ActivityBase
    {
        private Button btnShuffle;
        public Button BtnShuffle => btnShuffle ?? (btnShuffle = FindViewById<Button>(Resource.Id.btnShuffle));

        private Button btnMap;
        public Button BtnMap => btnMap ?? (btnMap = FindViewById<Button>(Resource.Id.btnMap));

        private TextView txtTeamName;
        public TextView TxtTeamName => txtTeamName ?? (txtTeamName = FindViewById<TextView>(Resource.Id.txtTeamName));

        private TextView txtStadium;
        public TextView TxtStadium => txtStadium ?? (txtStadium = FindViewById<TextView>(Resource.Id.txtStadium));

        private TextView txtCapacity;
        public TextView TxtCapacity => txtCapacity ?? (txtCapacity = FindViewById<TextView>(Resource.Id.txtCapacity));

        private EditText editShuffles;
        public EditText EditShuffles => editShuffles ?? (editShuffles = FindViewById<EditText>(Resource.Id.editShuffles));
    }
}