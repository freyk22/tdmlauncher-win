/*
 * Created by SharpDevelop.
 * User: freek
 * Date: 29-8-2016
 * Time: 16:05
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics; //for processes
using System.IO; //for searching files
using System.Text; //for searching files

namespace TDM_Launcher
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	/// 
	
	
	
	
	
	public partial class MainForm : Form
	{
		string strAppVersion = "v20160830";
		
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			lAppVersion.Text =  strAppVersion;
			tbLog.AppendText("Log made with TDM Launcher\n");
			tbProcessRO.Text = ".\\TheDarkMod.exe";
			
		}//end Mainform
		
		public void clsConfigValueSearch(string strSearchconfigline) { 
			//=====
			
			string line;
    		StringBuilder sb = new StringBuilder();

    		// Read the file and display it line by line.              
		    using(System.IO.StreamReader fTDMConfigfileSearch = new System.IO.StreamReader(".\\Darkmod.cfg"))
		    {
		       while((line = fTDMConfigfileSearch.ReadLine()) != null)             
		       {     
		         //if ( line.Contains(txtZoek.Text) )
				if ( line.Contains(strSearchconfigline) )		         
		         {          
		              // This append the text and a newline into the StringBuilder buffer       
		              sb.AppendLine(line.ToString());
		         }                   
		      }               
		   }
		    string strConfigLineFound = sb.ToString();
		    string strConfigLineValue = "";
		    
		    string[] values = strConfigLineFound.Split(' ');
			foreach (string value in values)
			{
	    		 strConfigLineValue = value.Replace("\"", "");
			}
		   	tbLog.AppendText("found:" + strConfigLineValue +"\n");
		   	//return strConfigLineValue;
		   	
			//=====
		}//end clsConfigValueSearch
		
		
		//string strProcessLaunch = "";
		//string strProcessArguments = "";
		
		void BLauncherRunClick(object sender, EventArgs e)
		{
			tbLog.AppendText("Date - " + DateTime.Now.ToString("yyyyMMdd-HH:mm:ss") + "\n");
			tbLog.AppendText("\nRun - " + tbProcessRO.Text + " " + tbArguments.Text + "\n");
			if (File.Exists(tbProcessRO.Text)){
				Process.Start(tbProcessRO.Text, tbArguments.Text);
			}else{
			tbLog.AppendText("Error - Cant find "+ tbProcessRO.Text + "\n\n");
			}
			
			tbLog.AppendText("Date - " + DateTime.Now.ToString("yyyyMMdd-HH:mm:ss") + "\n");
			tbLog.AppendText("Done.\n\n");
			
		}//BLauncherRunClick
		
		
		
		
		
		
		void RbTDMCheckedChanged(object sender, EventArgs e)
		{
	
			if (rbTDM.Checked){
				//tbProcessRO.Text = ".\\TheDarkMod.exe";
				//tbProcessRO.Text = "c:\\windows\\system32\\notepad.exe";
				tbProcessRO.Text = ".\\TheDarkMod.exe";
				tbArguments.Text = "";
			}
			
		}//end rbTDMCheckedChanged
		
		void RbUpdaterCheckedChanged(object sender, EventArgs e)
		{
			if (rbUpdater.Checked){
				//tbProcessRO.Text = ".\\tdm_update.exe";
				//tbProcessRO.Text = "c:\\windows\\system32\\calc.exe";
				tbProcessRO.Text = ".\\tdm_update.exe";
				tbArguments.Text = "";
			}
			
		}//end RbUpdaterCheckedChanged
		
		void BTBLogClearClick(object sender, EventArgs e)
		{
			tbLog.Text = "";
			tbLog.AppendText("TDM Launcher - Created by Freek 'Freyk' Borgerink\n");
		}//end BTBLogClearClick
		
		
		
		void TbLogTextChanged(object sender, EventArgs e)
		{
	
		}
		void BConfigLoadClick(object sender, EventArgs e)
		{
			/*
			 seta r_customHeight "486"
				seta r_customWidth "720" 
			 */

			//=======================
			tbLog.AppendText("Loading - values from Darkmod.cfg\n");
			
			clsConfigValueSearch("customHeight");
		
			
			
			
			//tbLog.AppendText(strConfigLineValue);
			// Search values in config file
			/*
			string line;
    		StringBuilder sb = new StringBuilder();

    		// Read the file and display it line by line.              
		    using(System.IO.StreamReader fTDMConfigfileSearch = new System.IO.StreamReader(".\\Darkmod.cfg"))
		    {
		       while((line = fTDMConfigfileSearch.ReadLine()) != null)             
		       {     
		         //if ( line.Contains(txtZoek.Text) )
				if ( line.Contains("customHeight") )		         
		         {          
		              // This append the text and a newline into the StringBuilder buffer       
		              sb.AppendLine(line.ToString());
		         }                   
		      }               
		   }
		    string strConfigLineFound = sb.ToString();
		    string strConfigLineValue = "";
		    
		    string[] values = strConfigLineFound.Split(' ');
			foreach (string value in values)
			{
	    		 strConfigLineValue = value.Replace("\"", "");;
			}
		   	tbLog.AppendText("found:" + strConfigLineValue +"\n");
		   	*/
			//=======================
		}
		void CbFPSShowCheckedChanged(object sender, EventArgs e)
		{
	
			if (cbFPSShow.Checked){
				tbArguments.AppendText("+com_showFPS 1 ");
				//if (!cbFPSShow.Checked)
			}else{
				tbArguments.Text = tbArguments.Text.Replace("+com_showFPS 1", "");
			}
			
		}//end CbFPSShowCheckedChanged
		
		
		void CbScreenResWindowCheckedChanged(object sender, EventArgs e)
		{
	
			if (cbScreenResWindow.Checked)
			{
				tbArguments.AppendText("+r_fullscreen 0 ");
				//(!cbScreenResWindow.Checked)
			}else{
				tbArguments.Text = tbArguments.Text.Replace("+r_fullscreen 0 ", "");
			}
			
		}//end cbScreenResWindowCheckedChanged
	}
}

/*
Changelog:
20160830
- Added smaller interface
- added screenresolution options

20160829
- Added: Start project
- Added interface

 */
 
