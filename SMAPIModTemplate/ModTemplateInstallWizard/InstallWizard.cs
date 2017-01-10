using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Microsoft.VisualStudio.TemplateWizard;
using EnvDTE;
using ModTemplateInstallWizard.Forms;

namespace ModTemplateInstallWizard
{
    public class InstallWizard : IWizard
    {
        public void BeforeOpeningFile(ProjectItem projectItem)
        {
        }

        public void ProjectFinishedGenerating(Project project)
        {
        }

        public void ProjectItemFinishedGenerating(ProjectItem projectItem)
        {
            MessageBox.Show($"Finished processing: {projectItem.Name}");
        }

        public void RunFinished()
        {
        }

        private UserInputForm inputForm;
        private string customMessage;
        public void RunStarted(object automationObject, Dictionary<string, string> replacementsDictionary, WizardRunKind runKind, object[] customParams)
        {
            try
            {
                // Display a form to the user. The form collects 
                // input for the custom message.
                inputForm = new UserInputForm();
                inputForm.ShowDialog();

                customMessage = inputForm.CustomMessage != null ? inputForm.CustomMessage : "default";

                // Add custom parameters.
                replacementsDictionary.Add("$custommessage$", customMessage);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public bool ShouldAddProjectItem(string filePath)
        {
            return true;
        }
    }
}
