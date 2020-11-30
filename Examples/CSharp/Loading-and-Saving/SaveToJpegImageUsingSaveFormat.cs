// -----------------------------------------------------------------------
//  <copyright file="SaveToJpegImageUsingSaveFormat.cs" company="Aspose Pty Ltd">
//    Copyright (c) 2002-2020 Aspose Pty Ltd. All Rights Reserved.
//  </copyright>
// -----------------------------------------------------------------------

namespace Aspose.Note.Examples.CSharp.Loading_and_Saving
{
    using System;

    using Aspose.Note.Saving;

    class SaveToJpegImageUsingSaveFormat
    {
        public static void Run()
        {
            // ExStart:SaveToJpegImageUsingSaveFormat
            // ExFor:Document.Save(System.String, Aspose.Note.SaveOptions)
            // ExFor:SaveFormat
            // ExFor:ImageSaveOptions
            // ExFor:ImageSaveOptions.ColorMode
            // ExFor:ColorMode
            // ExSummary:Shows how to save a document as grayscale image.

            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_LoadingAndSaving();

            // Load the document into Aspose.Note.
            Document oneFile = new Document(dataDir + "Aspose.one");

            dataDir = dataDir + "SaveToJpegImageUsingSaveFormat_out.jpg";

            // Save the document as gif.
            oneFile.Save(dataDir, SaveFormat.Jpeg);

            // ExEnd:SaveToJpegImageUsingSaveFormat

            Console.WriteLine("\nOneNote document converted successfully to image in Jpeg.\nFile saved at " + dataDir);
        }
    }
}
