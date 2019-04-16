using Alexa.NET.Response;
using Alexa.NET.Response.APL;
using System;
using System.Collections.Generic;

namespace Reflexa
{
    class DisplayHelper
    {
        public static float DeviceHeight { get; set; } = 1080f;


        public static string GetWidth(float percentage)
        {
            return Math.Round(percentage * Core.echo.Viewport.PixelWidth) + "px";
        }

        public static string GetHeight(float percentage)
        {
            return Math.Round(percentage * Core.echo.Viewport.PixelHeight) + "px";
        }

        public static string GetWidth(float imageWidth, float imageHeight)
        {
            float ratio = imageHeight / DeviceHeight;
            float scaledImageHeight = ratio * Core.echo.Viewport.PixelHeight;
            float widthToHeight = imageWidth / imageHeight;

            return Math.Round(widthToHeight * scaledImageHeight) + "px";
        }

        public static string GetHeight(float imageWidth, float imageHeight)
        {
            float ratio = imageHeight / DeviceHeight;
            return GetHeight(ratio);
        }

        public static string GetMaxWidth()
        {
            return Math.Round((decimal)Core.echo.Viewport.PixelWidth) + "px";
        }

        public static string GetMaxHeight()
        {
            return Math.Round((decimal)Core.echo.Viewport.PixelHeight) + "px";
        }

        public static int GetPixelWidth(float percentage)
        {
            return (int)Math.Round(percentage * Core.echo.Viewport.PixelWidth);
        }

        public static int GetPixelHeight(float percentage)
        {
            return (int)Math.Round(percentage * Core.echo.Viewport.PixelHeight);
        }

        public static int GetPixelWidth(float imageWidth, float imageHeight)
        {
            float ratio = imageHeight / DeviceHeight;
            float scaledImageHeight = ratio * Core.echo.Viewport.PixelHeight;
            float widthToHeight = imageWidth / imageHeight;

            return (int)Math.Round(widthToHeight * scaledImageHeight);
        }

        public static int GetPixelHeight(float imageWidth, float imageHeight)
        {
            float ratio = imageHeight / DeviceHeight;
            return (int)Math.Round(ratio * Core.echo.Viewport.PixelHeight);
        }

        public static RenderDocumentDirective GetRenderDirective(string token, params APLComponent[] components)
        {
            RenderDocumentDirective renderDirective = new RenderDocumentDirective
            {
                Token = token,
                Document = new APLDocument()
            };

            renderDirective.Document.MainTemplate = new Layout().AsMain();
            renderDirective.Document.MainTemplate.Items = new List<APLComponent>();

            for (int i = 0; i < components.Length; i++)
                renderDirective.Document.MainTemplate.Items.Add(components[i]);

            return renderDirective;
        }
    }
}
