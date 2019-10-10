public class RotationSeries : Rotation
{
    int rotation;
    bool autoRotation;

    /// <summary>
    /// Start
    /// </summary>
    void Start()
    {
        autoRotation = false;
        InitializeCubeRotation();
        IdentObj.IdentifyPadRotation();
        MakeSeries.IntializeSeries();
        AttachSeriesOfCubes.InitializeAttachmentObject();
        AutoRotation.Initialize();
    }


    /// <summary>
    /// Update
    /// </summary>
    void Update()
    {
        if (autoRotation == false)
        {
            if (IdentObj.RotationPadRight.GetComponent<PadTouchDetection>().IsCollide && !rotating)
            {
                MakeSeries.SetRotationSeriesFromPadSelected(IdentObj.RotationPadRight.name);
                rotation = 0;
            }
            else if (IdentObj.RotationPadLeft.GetComponent<PadTouchDetection>().IsCollide && !rotating)
            {
                MakeSeries.SetRotationSeriesFromPadSelected(IdentObj.RotationPadLeft.name);
                rotation = 1;
            }
            else if (IdentObj.RotationPadDown.GetComponent<PadTouchDetection>().IsCollide && !rotating)
            {
                MakeSeries.SetRotationSeriesFromPadSelected(IdentObj.RotationPadDown.name);
                rotation = 4;
            }
            else if (IdentObj.RotationPadUp.GetComponent<PadTouchDetection>().IsCollide && !rotating)
            {
                MakeSeries.SetRotationSeriesFromPadSelected(IdentObj.RotationPadUp.name);
                rotation = 5;
            }
            else if (IdentObj.RotationPadForward.GetComponent<PadTouchDetection>().IsCollide && !rotating
                || IdentObj.RotationPadForward2.GetComponent<PadTouchDetection>().IsCollide && !rotating)
            {
                MakeSeries.SetRotationSeriesFromPadSelected(IdentObj.RotationPadForward.name);
                rotation = 3;
            }
            else if (IdentObj.RotationPadBackward.GetComponent<PadTouchDetection>().IsCollide && !rotating
                || IdentObj.RotationPadBackward2.GetComponent<PadTouchDetection>().IsCollide && !rotating)
            {
                MakeSeries.SetRotationSeriesFromPadSelected(IdentObj.RotationPadBackward.name);
                rotation = 2;
            }
            else if (IdentObj.Capteur1.GetComponent<PadTouchDetection>().IsCollide && !rotating)
            {
                MakeSeries.SetRotationSeriesFromPadSelected(IdentObj.Capteur1.name);
                rotation = 2;
            }
            else if (IdentObj.Capteur2.GetComponent<PadTouchDetection>().IsCollide && !rotating)
            {
                MakeSeries.SetRotationSeriesFromPadSelected(IdentObj.Capteur2.name);
                rotation = 2;
            }
            else if (IdentObj.Capteur3.GetComponent<PadTouchDetection>().IsCollide && !rotating)
            {
                MakeSeries.SetRotationSeriesFromPadSelected(IdentObj.Capteur3.name);
                rotation = 2;
            }
            else if (IdentObj.Capteur4.GetComponent<PadTouchDetection>().IsCollide && !rotating)
            {
                MakeSeries.SetRotationSeriesFromPadSelected(IdentObj.Capteur4.name);
                rotation = 4;
            }
            else if (IdentObj.Capteur5.GetComponent<PadTouchDetection>().IsCollide && !rotating)
            {
                MakeSeries.SetRotationSeriesFromPadSelected(IdentObj.Capteur5.name);
                rotation = 4;
            }
            else if (IdentObj.Capteur6.GetComponent<PadTouchDetection>().IsCollide && !rotating)
            {
                MakeSeries.SetRotationSeriesFromPadSelected(IdentObj.Capteur6.name);
                rotation = 4;
            }
            else if (IdentObj.Capteur7.GetComponent<PadTouchDetection>().IsCollide && !rotating)
            {
                MakeSeries.SetRotationSeriesFromPadSelected(IdentObj.Capteur7.name);
                rotation = 3;
            }
            else if (IdentObj.Capteur8.GetComponent<PadTouchDetection>().IsCollide && !rotating)
            {
                MakeSeries.SetRotationSeriesFromPadSelected(IdentObj.Capteur8.name);
                rotation = 3;
            }
            else if (IdentObj.Capteur9.GetComponent<PadTouchDetection>().IsCollide && !rotating)
            {
                MakeSeries.SetRotationSeriesFromPadSelected(IdentObj.Capteur9.name);
                rotation = 3;
            }
            else if (IdentObj.Capteur10.GetComponent<PadTouchDetection>().IsCollide && !rotating)
            {
                MakeSeries.SetRotationSeriesFromPadSelected(IdentObj.Capteur10.name);
                rotation = 5;
            }
            else if (IdentObj.Capteur11.GetComponent<PadTouchDetection>().IsCollide && !rotating)
            {
                MakeSeries.SetRotationSeriesFromPadSelected(IdentObj.Capteur11.name);
                rotation = 5;
            }
            else if (IdentObj.Capteur12.GetComponent<PadTouchDetection>().IsCollide && !rotating)
            {
                MakeSeries.SetRotationSeriesFromPadSelected(IdentObj.Capteur12.name);
                rotation = 5;
            }
            else if (IdentObj.Capteur13.GetComponent<PadTouchDetection>().IsCollide && !rotating)
            {
                MakeSeries.SetRotationSeriesFromPadSelected(IdentObj.Capteur13.name);
                rotation = 3;
            }
            else if (IdentObj.Capteur14.GetComponent<PadTouchDetection>().IsCollide && !rotating)
            {
                MakeSeries.SetRotationSeriesFromPadSelected(IdentObj.Capteur14.name);
                rotation = 3;
            }
            else if (IdentObj.Capteur15.GetComponent<PadTouchDetection>().IsCollide && !rotating)
            {
                MakeSeries.SetRotationSeriesFromPadSelected(IdentObj.Capteur15.name);
                rotation = 3;
            }
            else if (IdentObj.Capteur16.GetComponent<PadTouchDetection>().IsCollide && !rotating)
            {
                MakeSeries.SetRotationSeriesFromPadSelected(IdentObj.Capteur16.name);
                rotation = 5;
            }
            else if (IdentObj.Capteur17.GetComponent<PadTouchDetection>().IsCollide && !rotating)
            {
                MakeSeries.SetRotationSeriesFromPadSelected(IdentObj.Capteur17.name);
                rotation = 5;
            }
            else if (IdentObj.Capteur18.GetComponent<PadTouchDetection>().IsCollide && !rotating)
            {
                MakeSeries.SetRotationSeriesFromPadSelected(IdentObj.Capteur18.name);
                rotation = 5;
            }
            else if (IdentObj.Capteur19.GetComponent<PadTouchDetection>().IsCollide && !rotating)
            {
                MakeSeries.SetRotationSeriesFromPadSelected(IdentObj.Capteur19.name);
                rotation = 1;
            }
            else if (IdentObj.Capteur20.GetComponent<PadTouchDetection>().IsCollide && !rotating)
            {
                MakeSeries.SetRotationSeriesFromPadSelected(IdentObj.Capteur20.name);
                rotation = 0;
            }
            else if (IdentObj.Capteur21.GetComponent<PadTouchDetection>().IsCollide && !rotating)
            {
                MakeSeries.SetRotationSeriesFromPadSelected(IdentObj.Capteur21.name);
                rotation = 1;
            }
            else if (IdentObj.Capteur22.GetComponent<PadTouchDetection>().IsCollide && !rotating)
            {
                MakeSeries.SetRotationSeriesFromPadSelected(IdentObj.Capteur22.name);
                rotation = 0;
            }
            else if (IdentObj.Capteur23.GetComponent<PadTouchDetection>().IsCollide && !rotating)
            {
                MakeSeries.SetRotationSeriesFromPadSelected(IdentObj.Capteur23.name);
                rotation = 1;
            }
            else if (IdentObj.Capteur24.GetComponent<PadTouchDetection>().IsCollide && !rotating)
            {
                MakeSeries.SetRotationSeriesFromPadSelected(IdentObj.Capteur24.name);
                rotation = 0;
            }
            else if (IdentObj.Capteur25.GetComponent<PadTouchDetection>().IsCollide && !rotating)
            {
                MakeSeries.SetRotationSeriesFromPadSelected(IdentObj.Capteur25.name);
                rotation = 1;
            }
            else if (IdentObj.Capteur26.GetComponent<PadTouchDetection>().IsCollide && !rotating)
            {
                MakeSeries.SetRotationSeriesFromPadSelected(IdentObj.Capteur26.name);
                rotation = 0;
            }
            else if (IdentObj.Capteur27.GetComponent<PadTouchDetection>().IsCollide && !rotating)
            {
                MakeSeries.SetRotationSeriesFromPadSelected(IdentObj.Capteur27.name);
                rotation = 1;
            }
            else if (IdentObj.Capteur28.GetComponent<PadTouchDetection>().IsCollide && !rotating)
            {
                MakeSeries.SetRotationSeriesFromPadSelected(IdentObj.Capteur28.name);
                rotation = 0;
            }
            else if (IdentObj.Capteur29.GetComponent<PadTouchDetection>().IsCollide && !rotating)
            {
                MakeSeries.SetRotationSeriesFromPadSelected(IdentObj.Capteur29.name);
                rotation = 1;
            }
            else if (IdentObj.Capteur30.GetComponent<PadTouchDetection>().IsCollide && !rotating)
            {
                MakeSeries.SetRotationSeriesFromPadSelected(IdentObj.Capteur30.name);
                rotation = 0;
            }
            else if (IdentObj.Capteur31.GetComponent<PadTouchDetection>().IsCollide && !rotating)
            {
                MakeSeries.SetRotationSeriesFromPadSelected(IdentObj.Capteur31.name);
                rotation = 2;
            }
            else if (IdentObj.Capteur32.GetComponent<PadTouchDetection>().IsCollide && !rotating)
            {
                MakeSeries.SetRotationSeriesFromPadSelected(IdentObj.Capteur32.name);
                rotation = 2;
            }
            else if (IdentObj.Capteur33.GetComponent<PadTouchDetection>().IsCollide && !rotating)
            {
                MakeSeries.SetRotationSeriesFromPadSelected(IdentObj.Capteur33.name);
                rotation = 2;
            }
            else if (IdentObj.Capteur34.GetComponent<PadTouchDetection>().IsCollide && !rotating)
            {
                MakeSeries.SetRotationSeriesFromPadSelected(IdentObj.Capteur34.name);
                rotation = 4;
            }
            else if (IdentObj.Capteur35.GetComponent<PadTouchDetection>().IsCollide && !rotating)
            {
                MakeSeries.SetRotationSeriesFromPadSelected(IdentObj.Capteur35.name);
                rotation = 4;
            }
            else if (IdentObj.Capteur36.GetComponent<PadTouchDetection>().IsCollide && !rotating)
            {
                MakeSeries.SetRotationSeriesFromPadSelected(IdentObj.Capteur36.name);
                rotation = 4;
            }
            else            
                rotation = -1;           
        }
        else
        {
            if (IdentObj.Capteur1.GetComponent<PadTouchDetection>().IsCollide && !rotating)
            {
                AutoRotation.SetRotationSeriesByType("B");
                rotation = 2;
            }
            else if (IdentObj.Capteur9.GetComponent<PadTouchDetection>().IsCollide && !rotating)
            {
                AutoRotation.SetRotationSeriesByType("Bi");
                rotation = 3;
            }
            else if (IdentObj.Capteur3.GetComponent<PadTouchDetection>().IsCollide && !rotating)
            {
                AutoRotation.SetRotationSeriesByType("Fi");
                rotation = 2;
            }
            else if (IdentObj.Capteur7.GetComponent<PadTouchDetection>().IsCollide && !rotating)
            {
                AutoRotation.SetRotationSeriesByType("F");
                rotation = 3;
            }         
            else if (IdentObj.Capteur4.GetComponent<PadTouchDetection>().IsCollide && !rotating)
            {
                AutoRotation.SetRotationSeriesByType("L");
                rotation = 4;
            }
            else if (IdentObj.Capteur12.GetComponent<PadTouchDetection>().IsCollide && !rotating)
            {
                AutoRotation.SetRotationSeriesByType("Li");
                rotation = 5;
            }
            else if (IdentObj.Capteur6.GetComponent<PadTouchDetection>().IsCollide && !rotating)
            {
                AutoRotation.SetRotationSeriesByType("Ri");
                rotation = 4;
            }
            else if (IdentObj.Capteur10.GetComponent<PadTouchDetection>().IsCollide && !rotating)
            {
                AutoRotation.SetRotationSeriesByType("R");
                rotation = 5;
            }
            else if (IdentObj.Capteur19.GetComponent<PadTouchDetection>().IsCollide && !rotating)
            {
                AutoRotation.SetRotationSeriesByType("U");
                rotation = 1;
            }
            else if (IdentObj.Capteur22.GetComponent<PadTouchDetection>().IsCollide && !rotating)
            {
                AutoRotation.SetRotationSeriesByType("Ui");
                rotation = 0;
            }
            else if (IdentObj.Capteur27.GetComponent<PadTouchDetection>().IsCollide && !rotating)
            {
                AutoRotation.SetRotationSeriesByType("Di");
                rotation = 1;
            }
            else if (IdentObj.Capteur28.GetComponent<PadTouchDetection>().IsCollide && !rotating)
            {
                AutoRotation.SetRotationSeriesByType("D");
                rotation = 0;
            }
            else
                rotation = -1;
        }
              
        this.UpdateRotationDisk(rotation);       
    }
}
