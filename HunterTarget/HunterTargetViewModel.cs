using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HunterTarget
{
    public class HunterTargetViewModel : ObservableObject
    {
        #region Constructor
        public HunterTargetViewModel()
        {
            target_pitch_angle = 0;
            hunter_pitch_angle = 0;
            hunter_pitch_angle_shown = 0;
            target_pitch_angle_shown = 0;
            target_roll_angle = 0;
            hunter_roll_angle = 0;
            hunter_roll_angle_shown = 0;
            target_roll_angle_shown = 0;
            target_yaw_angle = 0;
            hunter_yaw_angle = 0;
            hunter_yaw_angle_shown = 0;
            target_yaw_angle_shown = 0;
            view_options = new List<string>{"Fixed Hunter", "Fixed Target", "Independent"};
        }
        #endregion Constructor

        #region Members

        private double hunter_pitch_angle;
        private double target_pitch_angle;
        private double hunter_pitch_wrt_target;
        private double hunter_pitch_angle_shown;
        private double target_pitch_angle_shown;

        private double hunter_yaw_angle;
        private double target_yaw_angle;
        private double hunter_yaw_wrt_target;
        private double hunter_yaw_angle_shown;
        private double target_yaw_angle_shown;

        private double hunter_roll_angle;
        private double target_roll_angle;
        private double hunter_roll_wrt_target;
        private double hunter_roll_angle_shown;
        private double target_roll_angle_shown;

        private List<string> view_options;
        private string selected_view_option;

        #endregion Members

        #region Properties


        public double Hunter_Pitch_Angle { get { return hunter_pitch_angle; } set { hunter_pitch_angle = value; OnPropertyChanged("Hunter_Pitch_Angle"); OnCurrentViewOptionChanged(); } }
        public double Target_Pitch_Angle { get { return target_pitch_angle; } set { target_pitch_angle = value; OnPropertyChanged("Target_Pitch_Angle"); OnCurrentViewOptionChanged(); } }
        public double Hunter_Pitch_WRT_Target { get { return hunter_pitch_wrt_target; } set { hunter_pitch_wrt_target = value; OnPropertyChanged("Hunter_Pitch_WRT_Target"); } }
        public double Hunter_Pitch_Angle_Shown { get { return hunter_pitch_angle_shown; } set { hunter_pitch_angle_shown = value; OnPropertyChanged("Hunter_Pitch_Angle_Shown"); } }
        public double Target_Pitch_Angle_Shown { get { return target_pitch_angle_shown; } set { target_pitch_angle_shown = value; OnPropertyChanged("Target_Pitch_Angle_Shown"); } }

        public double Hunter_Yaw_Angle { get { return hunter_yaw_angle; } set { hunter_yaw_angle = value; OnPropertyChanged("Hunter_Yaw_Angle"); OnCurrentViewOptionChanged(); } }
        public double Target_Yaw_Angle { get { return target_yaw_angle; } set { target_yaw_angle = value; OnPropertyChanged("Target_Yaw_Angle"); OnCurrentViewOptionChanged(); } }
        public double Hunter_Yaw_WRT_Target { get { return hunter_yaw_wrt_target; } set { hunter_yaw_wrt_target = value; OnPropertyChanged("Hunter_Yaw_WRT_Target"); } }
        public double Hunter_Yaw_Angle_Shown { get { return hunter_yaw_angle_shown; } set { hunter_yaw_angle_shown = value; OnPropertyChanged("Hunter_Yaw_Angle_Shown"); } }
        public double Target_Yaw_Angle_Shown { get { return target_yaw_angle_shown; } set { target_yaw_angle_shown = value; OnPropertyChanged("Target_Yaw_Angle_Shown"); } }

        public double Hunter_Roll_Angle { get { return hunter_roll_angle; } set { hunter_roll_angle = value; OnPropertyChanged("Hunter_Roll_Angle"); OnCurrentViewOptionChanged(); } }
        public double Target_Roll_Angle { get { return target_roll_angle; } set { target_roll_angle = value; OnPropertyChanged("Target_Roll_Angle"); OnCurrentViewOptionChanged(); } }
        public double Hunter_Roll_WRT_Target { get { return hunter_roll_wrt_target; } set { hunter_roll_wrt_target = value; OnPropertyChanged("Hunter_Roll_WRT_Target"); } }
        public double Hunter_Roll_Angle_Shown { get { return hunter_roll_angle_shown; } set { hunter_roll_angle_shown = value; OnPropertyChanged("Hunter_Roll_Angle_Shown"); } }
        public double Target_Roll_Angle_Shown { get { return target_roll_angle_shown; } set { target_roll_angle_shown = value; OnPropertyChanged("Target_Roll_Angle_Shown"); } }

        public List<string> View_Options { get { return view_options; } set { view_options = value; OnPropertyChanged("View_Options"); } }
        public string Selected_View_Option { get { return selected_view_option; } set { selected_view_option = value; OnPropertyChanged("Selected_View_Option"); OnCurrentViewOptionChanged(); } }
        #endregion Properties

        #region Class Methods
        /// <summary>
        /// On button click the angle will increase
        /// </summary>
        public void OnTarget_Pitch_AngleIncreased()
        {
            Target_Pitch_Angle += 3;
            Hunter_Pitch_WRT_Target = Hunter_Pitch_Angle - Target_Pitch_Angle;
        }

        public void OnTarget_Pitch_AngleDecreased()
        {
            Target_Pitch_Angle -= 3;
            Hunter_Pitch_WRT_Target = Hunter_Pitch_Angle - Target_Pitch_Angle;
        }

        public void OnHunter_Pitch_AngleIncreased()
        {
            Hunter_Pitch_Angle += 3;
            Hunter_Pitch_WRT_Target = Hunter_Pitch_Angle - Target_Pitch_Angle;
        }

        public void OnHunter_Pitch_AngleDecreased()
        {
            Hunter_Pitch_Angle -= 3;
            Hunter_Pitch_WRT_Target = Hunter_Pitch_Angle - Target_Pitch_Angle;
        }

        public void OnTarget_Yaw_AngleIncreased()
        {
            Target_Yaw_Angle += 3;
            Hunter_Yaw_WRT_Target = Hunter_Yaw_Angle - Target_Yaw_Angle;
        }

        public void OnTarget_Yaw_AngleDecreased()
        {
            Target_Yaw_Angle -= 3;
            Hunter_Yaw_WRT_Target = Hunter_Yaw_Angle - Target_Yaw_Angle;
        }

        public void OnHunter_Yaw_AngleIncreased()
        {
            Hunter_Yaw_Angle += 3;
            Hunter_Yaw_WRT_Target = Hunter_Yaw_Angle - Target_Yaw_Angle;
        }

        public void OnHunter_Yaw_AngleDecreased()
        {
            Hunter_Yaw_Angle -= 3;
            Hunter_Yaw_WRT_Target = Hunter_Yaw_Angle - Target_Yaw_Angle;
        }

        public void OnTarget_Roll_AngleIncreased()
        {
            Target_Roll_Angle += 3;
            Hunter_Roll_WRT_Target = Hunter_Roll_Angle - Target_Roll_Angle;
        }

        public void OnTarget_Roll_AngleDecreased()
        {
            Target_Roll_Angle -= 3;
            Hunter_Roll_WRT_Target = Hunter_Roll_Angle - Target_Roll_Angle;
        }

        public void OnHunter_Roll_AngleIncreased()
        {
            Hunter_Roll_Angle += 3;
            Hunter_Roll_WRT_Target = Hunter_Roll_Angle - Target_Roll_Angle;
        }

        public void OnHunter_Roll_AngleDecreased()
        {
            Hunter_Roll_Angle -= 3;
            Hunter_Roll_WRT_Target = Hunter_Roll_Angle - Target_Roll_Angle;
        }
        /// <summary>
        /// Used to update values that are not directly related to button clicks
        /// </summary>
        private void OnValueChanged()
        {
            Hunter_Pitch_WRT_Target = Hunter_Pitch_Angle - Target_Pitch_Angle;
        }

        private void OnCurrentViewOptionChanged()
        {
            switch (Selected_View_Option)
            {
                case "Fixed Hunter"://Fixed hunter
                    Hunter_Pitch_Angle_Shown = 0;
                    Target_Pitch_Angle_Shown = - Hunter_Pitch_WRT_Target;
                    Hunter_Yaw_Angle_Shown = 0;
                    Target_Yaw_Angle_Shown = -Hunter_Yaw_WRT_Target;
                    Hunter_Roll_Angle_Shown = 0;
                    Target_Roll_Angle_Shown = -Hunter_Roll_WRT_Target;
                    break;
               
                case "Fixed Target"://Fixed target
                    Target_Pitch_Angle_Shown = 0;
                    Hunter_Pitch_Angle_Shown = Hunter_Pitch_WRT_Target;
                    Target_Yaw_Angle_Shown = 0;
                    Hunter_Yaw_Angle_Shown = Hunter_Yaw_WRT_Target;
                    Target_Roll_Angle_Shown = 0;
                    Hunter_Roll_Angle_Shown = Hunter_Roll_WRT_Target;
                    break;
                
                case "Independent"://independant
                    Target_Pitch_Angle_Shown = Target_Pitch_Angle;
                    Hunter_Pitch_Angle_Shown = Hunter_Pitch_Angle;
                    Target_Yaw_Angle_Shown = Target_Yaw_Angle;
                    Hunter_Yaw_Angle_Shown = Hunter_Yaw_Angle;
                    Target_Roll_Angle_Shown = Target_Roll_Angle;
                    Hunter_Roll_Angle_Shown = Hunter_Roll_Angle;
                    break;
            }
        }
        #endregion Class Methods
    }
}
