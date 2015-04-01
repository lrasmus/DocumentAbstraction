# Document Abstraction
This project was developed to be a simple, lightweight tool to create gold standard corpora at the document or sentence level.

## Features
* Sentence level annotation
* Document level annotation
* Plug-in architecture for your own annotation schemes
* Dictionary for highlighting text in documents

## Annotation Plug-ins
An opportunity for improvement is to provide configuration-driven annotation schemes.  To date this requires you to develop a DLL with a visual component and a data interface.  Several examples are provided in this repository.

## Configuration
The following configuration options are available within the main app.config file:

* Dictionary - path to a dictionary file, if used.  Path may be absolute or relative (e.g. WordList.txt)
* FieldDelimiter - the delimiter to use within the output file for annotations (e.g. |)
* DocumentRepository - the directory where the text documents to be annotated are located.  May be absolute or relative (e.g. .\TestDocs)
* DocumentFilePattern - wildcard pattern, like you would use in ls / dir, to identify the files in the DocumentRepository directory to use (e.g. *.txt)
* Annotations - the file where annotations should be written.  May be absolute or relative (e.g. Annotations.txt)
* AssessmentAssemblyLocation - path to the DLL which contains the assessment/annotation UI control and input/output logic (e.g. ColonPolypAbstraction.dll)
* AssessmentClass - the class name within the assessment assembly that defines the input/output logic (e.g. ColonPolypAbstraction.ColonPolypAnnotation)
* AssessmentControl - the class name within the assessment assembly that defines the UI control (e.g. ColonPolypAbstraction.ColonPolypAssessment)
* SentenceAnnotations - flag to indicate if you are allowing sentence-level annotations, or if it's just document level (values: true|false)
* HighlightTermsInDocument - flag to indicate if the dictionary should be used to highlight terms within the document text (value: true|false)

## Acknowledgements
This application was developed in part by the Marshfield Clinic Research Foundation (http://www.marshfieldresearch.org/) and the Northwestern University Feinberg School of Medicine (http://www.feinberg.northwestern.edu/).

This work was completed as part of the electronic Medical Records and Genomics (eMERGE) Network.  The eMERGE Network was initiated and funded by NHGRI, in conjunction with additional funding from NIGMS through the following grants: U01-HG-004610 (Group Health Cooperative/University of Washington); U01-HG-004608 (Marshfield Clinic Research Foundation and Vanderbilt University Medical Center); U01-HG-04599 (Mayo Clinic); U01HG004609 (Northwestern University); U01-HG-04603 (Vanderbilt University Medical Center, also serving as the Administrative Coordinating Center).

The eMERGE Network receives funding NHGRI through the following grants: U01HG006828 (Cincinnati Children’s Hospital Medical Center/Boston Children’s Hospital); U01HG006830 (Children’s Hospital of Philadelphia); U01HG006389 (Essentia Institute of Rural Health, Marshfield Clinic Research Foundation and Pennsylvania State University); U01HG006382 (Geisinger Clinic);  U01HG006375 (Group Health Cooperative/University of Washington); U01HG006379 (Mayo Clinic); U01HG006380 (Icahn School of Medicine at Mount Sinai); U01HG006388 (Northwestern University); U01HG006378 (Vanderbilt University Medical Center); and U01HG006385 (Vanderbilt University Medical Center serving as the Coordinating Center).

In addition, the primary author of this software was supported, in part, by the Northwestern University Clinical and Translational Science Institute, Grant Number UL1TR000150 from the National Center for Advancing Translational Sciences, Clinical and Translational Sciences Award (CTSA). The content is solely the responsibility of the authors and does not necessarily represent the official views of the NIH. The CTSA is a registered trademark of the U.S. Department of Health and Human Services (DHHS).

Licensed under the Apache License, Version 2.0 (read LICENSE for more information)
