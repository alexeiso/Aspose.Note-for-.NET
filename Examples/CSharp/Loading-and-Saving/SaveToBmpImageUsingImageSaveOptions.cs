// -----------------------------------------------------------------------
//  <copyright file="SaveToBmpImageUsingImageSaveOptions.cs" company="Aspose Pty Ltd">
//    Copyright (c) 2002-2020 Aspose Pty Ltd. All Rights Reserved.
//  </copyright>
// -----------------------------------------------------------------------

namespace Aspose.Note.Examples.CSharp.Loading_and_Saving
{
    using System;

    using Aspose.Note.Saving;

    class SaveToBmpImageUsingImageSaveOptions
    {
        public static void Run()
        {
            // ExStart:SaveToBmpImageUsingImageSaveOptions
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

            dataDir = dataDir + "SaveToBmpImageUsingImageSaveOptions_out.bmp";

            // Save the document as gif.
            oneFile.Save(dataDir, new ImageSaveOptions(SaveFormat.Bmp));

            // ExEnd:SaveToBmpImageUsingImageSaveOptions

            Console.WriteLine("\nOneNote document converted successfully to image in Bmp.\nFile saved at " + dataDir);
        }
    }
}
