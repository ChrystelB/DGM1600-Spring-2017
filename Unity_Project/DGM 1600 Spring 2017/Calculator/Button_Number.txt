using UnityEngine;
using System.Collections;

public class Button_Number : MonoBehavior {

private void cmd1_Click(object sender, System.EventArgs e)

{
    if (inputStatus)

    {

        txtInput.Text += cmd1.Text;

    }

    else

    {
        txtInput.Text = cmd1.Text;

        inputStatus = true;

    }

}
}
