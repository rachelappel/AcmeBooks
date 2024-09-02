using System.ComponentModel.DataAnnotations;

namespace AcmeBooksAPI.Models;

public enum FileFormat
{
    [Display(Name = "Portable Document Format")]
    PDF = 0,
    [Display(Name = "Electronic Publication")]
    EPUB = 1,
    [Display(Name = "MobiPocket")]
    MOBI = 2,
    [Display(Name = "Amazon Kindle")]
    AZW = 3,
    [Display(Name = "Plain Text")]
    TXT = 4,
    [Display(Name = "Microsoft Word")]
    DOCX = 5
}