﻿namespace Amazon.AutoScaling.Model
{
    using System;
    using System.Collections.Generic;
    using System.Xml.Serialization;

    [XmlRoot(Namespace="http://autoscaling.amazonaws.com/doc/2009-05-15/", IsNullable=false)]
    public class Trigger
    {
        private string autoScalingGroupNameField;
        private decimal? breachDurationField;
        private DateTime? createdTimeField;
        private string customUnitField;
        private List<Dimension> dimensionsField;
        private string lowerBreachScaleIncrementField;
        private double? lowerThresholdField;
        private string measureNameField;
        private string namespaceValueField;
        private decimal? periodField;
        private string statisticField;
        private string statusField;
        private string triggerNameField;
        private string unitField;
        private string upperBreachScaleIncrementField;
        private double? upperThresholdField;

        public bool IsSetAutoScalingGroupName()
        {
            return (this.autoScalingGroupNameField != null);
        }

        public bool IsSetBreachDuration()
        {
            return this.breachDurationField.HasValue;
        }

        public bool IsSetCreatedTime()
        {
            return this.createdTimeField.HasValue;
        }

        public bool IsSetCustomUnit()
        {
            return (this.customUnitField != null);
        }

        public bool IsSetDimensions()
        {
            return (this.Dimensions.Count > 0);
        }

        public bool IsSetLowerBreachScaleIncrement()
        {
            return (this.lowerBreachScaleIncrementField != null);
        }

        public bool IsSetLowerThreshold()
        {
            return this.lowerThresholdField.HasValue;
        }

        public bool IsSetMeasureName()
        {
            return (this.measureNameField != null);
        }

        public bool IsSetNamespace()
        {
            return (this.namespaceValueField != null);
        }

        public bool IsSetPeriod()
        {
            return this.periodField.HasValue;
        }

        public bool IsSetStatistic()
        {
            return (this.statisticField != null);
        }

        public bool IsSetStatus()
        {
            return (this.statusField != null);
        }

        public bool IsSetTriggerName()
        {
            return (this.triggerNameField != null);
        }

        public bool IsSetUnit()
        {
            return (this.unitField != null);
        }

        public bool IsSetUpperBreachScaleIncrement()
        {
            return (this.upperBreachScaleIncrementField != null);
        }

        public bool IsSetUpperThreshold()
        {
            return this.upperThresholdField.HasValue;
        }

        public Trigger WithAutoScalingGroupName(string autoScalingGroupName)
        {
            this.autoScalingGroupNameField = autoScalingGroupName;
            return this;
        }

        public Trigger WithBreachDuration(decimal breachDuration)
        {
            this.breachDurationField = new decimal?(breachDuration);
            return this;
        }

        public Trigger WithCreatedTime(DateTime createdTime)
        {
            this.createdTimeField = new DateTime?(createdTime);
            return this;
        }

        public Trigger WithCustomUnit(string customUnit)
        {
            this.customUnitField = customUnit;
            return this;
        }

        public Trigger WithDimensions(params Dimension[] list)
        {
            foreach (Dimension dimension in list)
            {
                this.Dimensions.Add(dimension);
            }
            return this;
        }

        public Trigger WithLowerBreachScaleIncrement(string lowerBreachScaleIncrement)
        {
            this.lowerBreachScaleIncrementField = lowerBreachScaleIncrement;
            return this;
        }

        public Trigger WithLowerThreshold(double lowerThreshold)
        {
            this.lowerThresholdField = new double?(lowerThreshold);
            return this;
        }

        public Trigger WithMeasureName(string measureName)
        {
            this.measureNameField = measureName;
            return this;
        }

        public Trigger WithNamespace(string namespaceValue)
        {
            this.namespaceValueField = namespaceValue;
            return this;
        }

        public Trigger WithPeriod(decimal period)
        {
            this.periodField = new decimal?(period);
            return this;
        }

        public Trigger WithStatistic(string statistic)
        {
            this.statisticField = statistic;
            return this;
        }

        public Trigger WithStatus(string status)
        {
            this.statusField = status;
            return this;
        }

        public Trigger WithTriggerName(string triggerName)
        {
            this.triggerNameField = triggerName;
            return this;
        }

        public Trigger WithUnit(string unit)
        {
            this.unitField = unit;
            return this;
        }

        public Trigger WithUpperBreachScaleIncrement(string upperBreachScaleIncrement)
        {
            this.upperBreachScaleIncrementField = upperBreachScaleIncrement;
            return this;
        }

        public Trigger WithUpperThreshold(double upperThreshold)
        {
            this.upperThresholdField = new double?(upperThreshold);
            return this;
        }

        [XmlElement(ElementName="AutoScalingGroupName")]
        public string AutoScalingGroupName
        {
            get
            {
                return this.autoScalingGroupNameField;
            }
            set
            {
                this.autoScalingGroupNameField = value;
            }
        }

        [XmlElement(ElementName="BreachDuration")]
        public decimal BreachDuration
        {
            get
            {
                return this.breachDurationField.GetValueOrDefault();
            }
            set
            {
                this.breachDurationField = new decimal?(value);
            }
        }

        [XmlElement(ElementName="CreatedTime")]
        public DateTime CreatedTime
        {
            get
            {
                return this.createdTimeField.GetValueOrDefault();
            }
            set
            {
                this.createdTimeField = new DateTime?(value);
            }
        }

        [XmlElement(ElementName="CustomUnit")]
        public string CustomUnit
        {
            get
            {
                return this.customUnitField;
            }
            set
            {
                this.customUnitField = value;
            }
        }

        [XmlElement(ElementName="Dimensions")]
        public List<Dimension> Dimensions
        {
            get
            {
                if (this.dimensionsField == null)
                {
                    this.dimensionsField = new List<Dimension>();
                }
                return this.dimensionsField;
            }
            set
            {
                this.dimensionsField = value;
            }
        }

        [XmlElement(ElementName="LowerBreachScaleIncrement")]
        public string LowerBreachScaleIncrement
        {
            get
            {
                return this.lowerBreachScaleIncrementField;
            }
            set
            {
                this.lowerBreachScaleIncrementField = value;
            }
        }

        [XmlElement(ElementName="LowerThreshold")]
        public double LowerThreshold
        {
            get
            {
                return this.lowerThresholdField.GetValueOrDefault();
            }
            set
            {
                this.lowerThresholdField = new double?(value);
            }
        }

        [XmlElement(ElementName="MeasureName")]
        public string MeasureName
        {
            get
            {
                return this.measureNameField;
            }
            set
            {
                this.measureNameField = value;
            }
        }

        [XmlElement(ElementName="Namespace")]
        public string Namespace
        {
            get
            {
                return this.namespaceValueField;
            }
            set
            {
                this.namespaceValueField = value;
            }
        }

        [XmlElement(ElementName="Period")]
        public decimal Period
        {
            get
            {
                return this.periodField.GetValueOrDefault();
            }
            set
            {
                this.periodField = new decimal?(value);
            }
        }

        [XmlElement(ElementName="Statistic")]
        public string Statistic
        {
            get
            {
                return this.statisticField;
            }
            set
            {
                this.statisticField = value;
            }
        }

        [XmlElement(ElementName="Status")]
        public string Status
        {
            get
            {
                return this.statusField;
            }
            set
            {
                this.statusField = value;
            }
        }

        [XmlElement(ElementName="TriggerName")]
        public string TriggerName
        {
            get
            {
                return this.triggerNameField;
            }
            set
            {
                this.triggerNameField = value;
            }
        }

        [XmlElement(ElementName="Unit")]
        public string Unit
        {
            get
            {
                return this.unitField;
            }
            set
            {
                this.unitField = value;
            }
        }

        [XmlElement(ElementName="UpperBreachScaleIncrement")]
        public string UpperBreachScaleIncrement
        {
            get
            {
                return this.upperBreachScaleIncrementField;
            }
            set
            {
                this.upperBreachScaleIncrementField = value;
            }
        }

        [XmlElement(ElementName="UpperThreshold")]
        public double UpperThreshold
        {
            get
            {
                return this.upperThresholdField.GetValueOrDefault();
            }
            set
            {
                this.upperThresholdField = new double?(value);
            }
        }
    }
}

