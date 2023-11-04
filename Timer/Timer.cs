using System;
using System.Diagnostics;

class Program
{
	    static Stopwatch stopwatch = new Stopwatch();
	        static TimeSpan elapsed = TimeSpan.Zero;

		    static void Main()
			        {
					        Console.WriteLine("Stopwatch Timer (HH:mm:ss Format)");
						        Console.WriteLine("Commands: start, pause, resume, reset, stop, exit");

							        while (true)
									        {
											            string input = Console.ReadLine().ToLower();
												                switch (input)
															            {
																	                    case "start":
																				                        StartTimer();
																							                    break;
																									                    case "pause":
																									                        PauseTimer();
																												                    break;
																														                    case "resume":
																														                        ResumeTimer();
																																	                    break;
																																			                    case "reset":
																																			                        ResetTimer();
																																						                    break;
																																								                    case "stop":
																																								                        StopTimer();
																																											                    break;
																																													                    case "exit":
																																													                        Environment.Exit(0);
																																																                    break;
																																																		                    default:
																																																		                        Console.WriteLine("Invalid command. Try again.");
																																																					                    break;
																																																							                }
														        }
								    }

		        static void StartTimer()
				    {
					            if (!stopwatch.IsRunning)
							            {
									                stopwatch.Start();
											            Console.WriteLine("Timer started.");
												                while (stopwatch.IsRunning)
															            {
																	                    elapsed = stopwatch.Elapsed;
																			                    Console.Write($"\rElapsed Time: {elapsed:hh\\:mm\\:ss}");
																					                }
														        }
						        }

			    static void PauseTimer()
				        {
						        if (stopwatch.IsRunning)
								        {
										            stopwatch.Stop();
											                Console.WriteLine($"\rPaused at {elapsed:hh\\:mm\\:ss}");
													        }
							        else
									        {
											            Console.WriteLine("Timer is not running.");
												            }
								    }

			        static void ResumeTimer()
					    {
						            if (!stopwatch.IsRunning && stopwatch.Elapsed > TimeSpan.Zero)
								            {
										                stopwatch.Start();
												            Console.WriteLine("\rResumed.");
													                while (stopwatch.IsRunning)
																            {
																		                    elapsed = stopwatch.Elapsed;
																				                    Console.Write($"\rElapsed Time: {elapsed:hh\\:mm\\:ss}");
																						                }
															        }
							        }

				    static void ResetTimer()
					        {
							        if (stopwatch.IsRunning)
									        {
											            stopwatch.Stop();
												            }
								        elapsed = TimeSpan.Zero;
									        stopwatch.Reset();
										        Console.WriteLine("Timer reset to 00:00:00.");
											    }

				        static void StopTimer()
						    {
							            if (stopwatch.IsRunning)
									            {
											                stopwatch.Stop();
													            Console.WriteLine($"\rElapsed Time: {elapsed:hh\\:mm\\:ss}");
														            }
								            else
										            {
												                Console.WriteLine("Timer is not running.");
														        }
									        }
}
