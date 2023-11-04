using System;
using System.Windows.Forms;
using System.Diagnostics;

namespace StopwatchTimerApp
{
	    public partial class MainForm : Form
					        {
							        private Stopwatch stopwatch = new Stopwatch();
								        private TimeSpan elapsed;

									        public MainForm()
											        {
													            InitializeComponent();
														            }

										        private void MainForm_Load(object sender, EventArgs e)
												        {
														            timer1.Interval = 1000; // 1 second interval
															                timer1.Tick += new EventHandler(UpdateTimer);
																	        }

											        private void UpdateTimer(object sender, EventArgs e)
													        {
															            elapsed = stopwatch.Elapsed;
																                labelTime.Text = elapsed.ToString(@"hh\:mm\:ss");
																		        }

												        private void btnStart_Click(object sender, EventArgs e)
														        {
																            if (!stopwatch.IsRunning)
																		                {
																					                timer1.Start();
																							                stopwatch.Start();
																									            }
																	            }

													        private void btnPause_Click(object sender, EventArgs e)
															        {
																	            if (stopwatch.IsRunning)
																			                {
																						                timer1.Stop();
																								                stopwatch.Stop();
																										            }
																		            }

														        private void btnResume_Click(object sender, EventArgs e)
																        {
																		            if (!stopwatch.IsRunning)
																				                {
																							                timer1.Start();
																									                stopwatch.Start();
																											            }
																			            }

															        private void btnReset_Click(object sender, EventArgs e)
																	        {
																			            timer1.Stop();
																				                stopwatch.Reset();
																						            elapsed = TimeSpan.Zero;
																							                labelTime.Text = elapsed.ToString(@"hh\:mm\:ss");
																									        }

																        private void btnStop_Click(object sender, EventArgs e)
																		        {
																				            if (stopwatch.IsRunning)
																						                {
																									                timer1.Stop();
																											                stopwatch.Stop();
																													            }

																					                MessageBox.Show($"Elapsed Time: {elapsed.ToString(@"hh\:mm\:ss")}", "Stopwatch Stopped", MessageBoxButtons.OK, MessageBoxIcon.Information);
																							        }
																	    }
}

