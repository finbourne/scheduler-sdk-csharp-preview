/*
 * FINBOURNE Scheduler API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 0.0.752
 * Contact: info@finbourne.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Finbourne.Scheduler.Sdk.Client.OpenAPIDateConverter;

namespace Finbourne.Scheduler.Sdk.Model
{
    /// <summary>
    /// Definition of a job
    /// </summary>
    [DataContract(Name = "CreateJobRequest")]
    public partial class CreateJobRequest : IEquatable<CreateJobRequest>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateJobRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreateJobRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateJobRequest" /> class.
        /// </summary>
        /// <param name="jobId">jobId (required).</param>
        /// <param name="name">Name of the job (required).</param>
        /// <param name="author">Author of the job.</param>
        /// <param name="dateCreated">Date when job was created. Defaults to now..</param>
        /// <param name="description">Description of this job (required).</param>
        /// <param name="imageName">The name of the Docker image that contains this job (required).</param>
        /// <param name="imageTag">The tag of the Docker image that contains this job (required).</param>
        /// <param name="command">The command for running this job.</param>
        /// <param name="ttl">Time To Live of the job run in seconds  Defaults to 5 minutes(300).</param>
        /// <param name="minCpu">Specifies  minimum number of CPUs to be allocated for the job  Default to 2.</param>
        /// <param name="maxCpu">Specifies  maximum number of CPUs to be allocated for the job.</param>
        /// <param name="minMemory">Specifies the minimum amount of memory  to be allocated for the job.</param>
        /// <param name="maxMemory">Specifies the maximum amount of memory to be allocated for the job.</param>
        /// <param name="argumentDefinitions">All arguments for this job to run (required).</param>
        /// <param name="commandLineArgumentSeparator">Value to separate command line arguments  e.g : If a job has a command line argument named &#39;folder&#39; and the runtime value is &#39;s3://path&#39; then this  would be supplied to the command as &#39;folder{separatorValue}s3://path&#39;  Default to a space.</param>
        /// <param name="requiredResources">requiredResources (required).</param>
        public CreateJobRequest(ResourceId jobId = default(ResourceId), string name = default(string), string author = default(string), DateTimeOffset dateCreated = default(DateTimeOffset), string description = default(string), string imageName = default(string), string imageTag = default(string), string command = default(string), int ttl = default(int), string minCpu = default(string), string maxCpu = default(string), string minMemory = default(string), string maxMemory = default(string), Dictionary<string, ArgumentDefinition> argumentDefinitions = default(Dictionary<string, ArgumentDefinition>), string commandLineArgumentSeparator = default(string), RequiredResources requiredResources = default(RequiredResources))
        {
            // to ensure "jobId" is required (not null)
            this.JobId = jobId ?? throw new ArgumentNullException("jobId is a required property for CreateJobRequest and cannot be null");
            // to ensure "name" is required (not null)
            this.Name = name ?? throw new ArgumentNullException("name is a required property for CreateJobRequest and cannot be null");
            // to ensure "description" is required (not null)
            this.Description = description ?? throw new ArgumentNullException("description is a required property for CreateJobRequest and cannot be null");
            // to ensure "imageName" is required (not null)
            this.ImageName = imageName ?? throw new ArgumentNullException("imageName is a required property for CreateJobRequest and cannot be null");
            // to ensure "imageTag" is required (not null)
            this.ImageTag = imageTag ?? throw new ArgumentNullException("imageTag is a required property for CreateJobRequest and cannot be null");
            // to ensure "argumentDefinitions" is required (not null)
            this.ArgumentDefinitions = argumentDefinitions ?? throw new ArgumentNullException("argumentDefinitions is a required property for CreateJobRequest and cannot be null");
            // to ensure "requiredResources" is required (not null)
            this.RequiredResources = requiredResources ?? throw new ArgumentNullException("requiredResources is a required property for CreateJobRequest and cannot be null");
            this.Author = author;
            this.DateCreated = dateCreated;
            this.Command = command;
            this.Ttl = ttl;
            this.MinCpu = minCpu;
            this.MaxCpu = maxCpu;
            this.MinMemory = minMemory;
            this.MaxMemory = maxMemory;
            this.CommandLineArgumentSeparator = commandLineArgumentSeparator;
        }

        /// <summary>
        /// Gets or Sets JobId
        /// </summary>
        [DataMember(Name = "jobId", IsRequired = true, EmitDefaultValue = false)]
        public ResourceId JobId { get; set; }

        /// <summary>
        /// Name of the job
        /// </summary>
        /// <value>Name of the job</value>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Author of the job
        /// </summary>
        /// <value>Author of the job</value>
        [DataMember(Name = "author", EmitDefaultValue = true)]
        public string Author { get; set; }

        /// <summary>
        /// Date when job was created. Defaults to now.
        /// </summary>
        /// <value>Date when job was created. Defaults to now.</value>
        [DataMember(Name = "dateCreated", EmitDefaultValue = false)]
        public DateTimeOffset DateCreated { get; set; }

        /// <summary>
        /// Description of this job
        /// </summary>
        /// <value>Description of this job</value>
        [DataMember(Name = "description", IsRequired = true, EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// The name of the Docker image that contains this job
        /// </summary>
        /// <value>The name of the Docker image that contains this job</value>
        [DataMember(Name = "imageName", IsRequired = true, EmitDefaultValue = false)]
        public string ImageName { get; set; }

        /// <summary>
        /// The tag of the Docker image that contains this job
        /// </summary>
        /// <value>The tag of the Docker image that contains this job</value>
        [DataMember(Name = "imageTag", IsRequired = true, EmitDefaultValue = false)]
        public string ImageTag { get; set; }

        /// <summary>
        /// The command for running this job
        /// </summary>
        /// <value>The command for running this job</value>
        [DataMember(Name = "command", EmitDefaultValue = true)]
        public string Command { get; set; }

        /// <summary>
        /// Time To Live of the job run in seconds  Defaults to 5 minutes(300)
        /// </summary>
        /// <value>Time To Live of the job run in seconds  Defaults to 5 minutes(300)</value>
        [DataMember(Name = "ttl", EmitDefaultValue = true)]
        public int Ttl { get; set; }

        /// <summary>
        /// Specifies  minimum number of CPUs to be allocated for the job  Default to 2
        /// </summary>
        /// <value>Specifies  minimum number of CPUs to be allocated for the job  Default to 2</value>
        [DataMember(Name = "minCpu", EmitDefaultValue = true)]
        public string MinCpu { get; set; }

        /// <summary>
        /// Specifies  maximum number of CPUs to be allocated for the job
        /// </summary>
        /// <value>Specifies  maximum number of CPUs to be allocated for the job</value>
        [DataMember(Name = "maxCpu", EmitDefaultValue = true)]
        public string MaxCpu { get; set; }

        /// <summary>
        /// Specifies the minimum amount of memory  to be allocated for the job
        /// </summary>
        /// <value>Specifies the minimum amount of memory  to be allocated for the job</value>
        [DataMember(Name = "minMemory", EmitDefaultValue = true)]
        public string MinMemory { get; set; }

        /// <summary>
        /// Specifies the maximum amount of memory to be allocated for the job
        /// </summary>
        /// <value>Specifies the maximum amount of memory to be allocated for the job</value>
        [DataMember(Name = "maxMemory", EmitDefaultValue = true)]
        public string MaxMemory { get; set; }

        /// <summary>
        /// All arguments for this job to run
        /// </summary>
        /// <value>All arguments for this job to run</value>
        [DataMember(Name = "argumentDefinitions", IsRequired = true, EmitDefaultValue = false)]
        public Dictionary<string, ArgumentDefinition> ArgumentDefinitions { get; set; }

        /// <summary>
        /// Value to separate command line arguments  e.g : If a job has a command line argument named &#39;folder&#39; and the runtime value is &#39;s3://path&#39; then this  would be supplied to the command as &#39;folder{separatorValue}s3://path&#39;  Default to a space
        /// </summary>
        /// <value>Value to separate command line arguments  e.g : If a job has a command line argument named &#39;folder&#39; and the runtime value is &#39;s3://path&#39; then this  would be supplied to the command as &#39;folder{separatorValue}s3://path&#39;  Default to a space</value>
        [DataMember(Name = "commandLineArgumentSeparator", EmitDefaultValue = true)]
        public string CommandLineArgumentSeparator { get; set; }

        /// <summary>
        /// Gets or Sets RequiredResources
        /// </summary>
        [DataMember(Name = "requiredResources", IsRequired = true, EmitDefaultValue = false)]
        public RequiredResources RequiredResources { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateJobRequest {\n");
            sb.Append("  JobId: ").Append(JobId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Author: ").Append(Author).Append("\n");
            sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  ImageName: ").Append(ImageName).Append("\n");
            sb.Append("  ImageTag: ").Append(ImageTag).Append("\n");
            sb.Append("  Command: ").Append(Command).Append("\n");
            sb.Append("  Ttl: ").Append(Ttl).Append("\n");
            sb.Append("  MinCpu: ").Append(MinCpu).Append("\n");
            sb.Append("  MaxCpu: ").Append(MaxCpu).Append("\n");
            sb.Append("  MinMemory: ").Append(MinMemory).Append("\n");
            sb.Append("  MaxMemory: ").Append(MaxMemory).Append("\n");
            sb.Append("  ArgumentDefinitions: ").Append(ArgumentDefinitions).Append("\n");
            sb.Append("  CommandLineArgumentSeparator: ").Append(CommandLineArgumentSeparator).Append("\n");
            sb.Append("  RequiredResources: ").Append(RequiredResources).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateJobRequest);
        }

        /// <summary>
        /// Returns true if CreateJobRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateJobRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateJobRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.JobId == input.JobId ||
                    (this.JobId != null &&
                    this.JobId.Equals(input.JobId))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Author == input.Author ||
                    (this.Author != null &&
                    this.Author.Equals(input.Author))
                ) && 
                (
                    this.DateCreated == input.DateCreated ||
                    (this.DateCreated != null &&
                    this.DateCreated.Equals(input.DateCreated))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.ImageName == input.ImageName ||
                    (this.ImageName != null &&
                    this.ImageName.Equals(input.ImageName))
                ) && 
                (
                    this.ImageTag == input.ImageTag ||
                    (this.ImageTag != null &&
                    this.ImageTag.Equals(input.ImageTag))
                ) && 
                (
                    this.Command == input.Command ||
                    (this.Command != null &&
                    this.Command.Equals(input.Command))
                ) && 
                (
                    this.Ttl == input.Ttl ||
                    this.Ttl.Equals(input.Ttl)
                ) && 
                (
                    this.MinCpu == input.MinCpu ||
                    (this.MinCpu != null &&
                    this.MinCpu.Equals(input.MinCpu))
                ) && 
                (
                    this.MaxCpu == input.MaxCpu ||
                    (this.MaxCpu != null &&
                    this.MaxCpu.Equals(input.MaxCpu))
                ) && 
                (
                    this.MinMemory == input.MinMemory ||
                    (this.MinMemory != null &&
                    this.MinMemory.Equals(input.MinMemory))
                ) && 
                (
                    this.MaxMemory == input.MaxMemory ||
                    (this.MaxMemory != null &&
                    this.MaxMemory.Equals(input.MaxMemory))
                ) && 
                (
                    this.ArgumentDefinitions == input.ArgumentDefinitions ||
                    this.ArgumentDefinitions != null &&
                    input.ArgumentDefinitions != null &&
                    this.ArgumentDefinitions.SequenceEqual(input.ArgumentDefinitions)
                ) && 
                (
                    this.CommandLineArgumentSeparator == input.CommandLineArgumentSeparator ||
                    (this.CommandLineArgumentSeparator != null &&
                    this.CommandLineArgumentSeparator.Equals(input.CommandLineArgumentSeparator))
                ) && 
                (
                    this.RequiredResources == input.RequiredResources ||
                    (this.RequiredResources != null &&
                    this.RequiredResources.Equals(input.RequiredResources))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.JobId != null)
                    hashCode = hashCode * 59 + this.JobId.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Author != null)
                    hashCode = hashCode * 59 + this.Author.GetHashCode();
                if (this.DateCreated != null)
                    hashCode = hashCode * 59 + this.DateCreated.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.ImageName != null)
                    hashCode = hashCode * 59 + this.ImageName.GetHashCode();
                if (this.ImageTag != null)
                    hashCode = hashCode * 59 + this.ImageTag.GetHashCode();
                if (this.Command != null)
                    hashCode = hashCode * 59 + this.Command.GetHashCode();
                hashCode = hashCode * 59 + this.Ttl.GetHashCode();
                if (this.MinCpu != null)
                    hashCode = hashCode * 59 + this.MinCpu.GetHashCode();
                if (this.MaxCpu != null)
                    hashCode = hashCode * 59 + this.MaxCpu.GetHashCode();
                if (this.MinMemory != null)
                    hashCode = hashCode * 59 + this.MinMemory.GetHashCode();
                if (this.MaxMemory != null)
                    hashCode = hashCode * 59 + this.MaxMemory.GetHashCode();
                if (this.ArgumentDefinitions != null)
                    hashCode = hashCode * 59 + this.ArgumentDefinitions.GetHashCode();
                if (this.CommandLineArgumentSeparator != null)
                    hashCode = hashCode * 59 + this.CommandLineArgumentSeparator.GetHashCode();
                if (this.RequiredResources != null)
                    hashCode = hashCode * 59 + this.RequiredResources.GetHashCode();
                return hashCode;
            }
        }

    }
}
